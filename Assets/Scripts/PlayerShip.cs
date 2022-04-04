using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : DeathEffectObject
{
    public int LifeRemaining = 100;
    public int HealthAmountDamaged = 10;
    public int LaserFiringInterval = 4;
    public GameObject LaserPrefab;
    public Sounds Sounds;
    public Readouts Readouts;
    public Sprite NormalShipSprite;
    public Sprite DamagedShipSprite;
    private int TimeInCurrentInterval = 0;
    private SpriteRenderer SpriteRenderer;
    private bool IsShipDisabled = false;


    private void Awake()
    {
        SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        Sounds.PlayCantinaSound();
        Cursor.visible = false;
        SpriteRenderer.sprite = NormalShipSprite;
        Readouts.ShowHealth(LifeRemaining);
        Readouts.Reset();
    }


    private void FixedUpdate()
    {
        Move();
        if (Input.GetMouseButton(0))
        {
            if (TimeInCurrentInterval == LaserFiringInterval / 2)
            {
                FireRightLaser();
                ++TimeInCurrentInterval;
            }
            else if (TimeInCurrentInterval == LaserFiringInterval)
            {
                FireLeftLaser();
                TimeInCurrentInterval = 0;
            }
            else
            {
                ++TimeInCurrentInterval;
            }
        }
        if (LifeRemaining <= 0)
        {
            DestroyShip();
        }

    }

    private void Move()
    {
        SpriteRenderer.transform.position = new Vector3(GetMouseXPosition(), GetMouseYPosition(), SpriteRenderer.transform.position.z);
        ConstrainShipToScreen();
    }

    private float GetMouseXPosition()
    {
        Vector3 mouseScreenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
        return mouseWorldPosition.x;
    }

    private float GetMouseYPosition()
    {
        Vector3 mouseScreenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
        return mouseWorldPosition.y;
    }

    private void ConstrainShipToScreen()
    {
        SpriteRenderer.transform.position = SpriteTools.ConstrainSpriteToScreen(SpriteRenderer);
    }

    private void FireLeftLaser()
    {
        Sounds.PlayFiringLaser();
        Vector3 LeftLaserFireLocation = new Vector3(SpriteRenderer.transform.position.x - 0.62f, SpriteRenderer.transform.position.y + 0.4f, SpriteRenderer.transform.position.z);
        Instantiate(LaserPrefab, LeftLaserFireLocation, Quaternion.identity);
    }

    private void FireRightLaser()
    {
        Sounds.PlayFiringLaser();
        Vector3 RightLaserFireLocation = new Vector3(SpriteRenderer.transform.position.x + 0.62f, SpriteRenderer.transform.position.y + 0.4f, SpriteRenderer.transform.position.z);
        Instantiate(LaserPrefab, RightLaserFireLocation, Quaternion.identity);
    }

    private void DestroyShip()
    {
        Sounds.StopSounds();
        Sounds.ShipExplosion();
        Sounds.PlayChewbaccaSound();
        Sounds.PlayImperialSongWhenLose();
        CreateDeathEffect();
        Disable();
    }

    public void DamageShip()
    {
        if (IsShipDisabled == false)
        {
            StartCoroutine(ShowShipDamageEffect());
        }
        LifeRemaining -= HealthAmountDamaged;
        if (LifeRemaining < 0)
        {
            LifeRemaining = 0;
        }
        Readouts.ShowHealth(LifeRemaining);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Laser") // ship should not be damaged by its own lasers
        {
            return;
        }
        DamageShip();
    }

    public void Enable()
    {
        IsShipDisabled = false;
        gameObject.SetActive(true);
    }

    public void Disable()
    {
        IsShipDisabled = true;
        gameObject.SetActive(false);
    }

    private void Reset()
    {
        LifeRemaining = 100;
    }

    IEnumerator ShowShipDamageEffect()
    {
        SpriteRenderer.sprite = DamagedShipSprite;
        yield return new WaitForSeconds(0.1f);
        SpriteRenderer.sprite = NormalShipSprite;
    }
}
