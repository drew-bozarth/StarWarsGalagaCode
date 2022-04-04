using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : DeathEffectObject
{
    private SpriteRenderer SpriteRenderer;

    private void Awake()
    {
        SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerShip" || collision.gameObject.tag == "Laser")
        {
            return;
        }
        CreateDeathEffect();
        Destroy(gameObject);
    }

    private void Move()
    {
        SpriteRenderer.transform.position = new Vector3(SpriteRenderer.transform.position.x, SpriteRenderer.transform.position.y + 0.1f, SpriteRenderer.transform.position.z);
        DestroyLaserIfAtTopOfScreen();
    }

    private void DestroyLaserIfAtTopOfScreen()
    {
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(SpriteRenderer.transform.position);
        if (screenPosition.y > (Screen.height - (Screen.height / 6)))
            Destroy(gameObject);
    }
}
