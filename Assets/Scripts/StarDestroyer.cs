using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarDestroyer : MonoBehaviour
{
    public GameObject laserPrefab;
    private SpriteRenderer SpriteRenderer;
    private float moveSpeed = .005f;
    private bool changeDirection = false;

    private bool isWaitingToShoot = false;
    private int minimumTimeToShoot = 1;
    private int maximumTimeToShoot = 2;
    private int secondsUntilShoot;
    private float laserOffsetY = 0.75f;
    private float laserOffsetZ = -0.25f;

    private void Awake()
    {
        SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        Move();
        if (!isWaitingToShoot)
        {
            isWaitingToShoot = true;
            secondsUntilShoot = Random.Range(minimumTimeToShoot, maximumTimeToShoot + 1);
            StartCoroutine(CountdownUntilShoot());
        }
    }

    private void Move()
    {
        if (changeDirection == true)
        {
            SpriteRenderer.transform.Translate(-1 * moveSpeed, 0f, 0f);
        }
        else if (changeDirection == false)
        {
            SpriteRenderer.transform.Translate(moveSpeed, 0f, 0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RightWall")
        {
            changeDirection = true;
        }
        else if (collision.gameObject.tag == "LeftWall")
        {
            changeDirection = false;
        }
    }

    IEnumerator CountdownUntilShoot()
    {
        yield return new WaitForSeconds(secondsUntilShoot);

        Create();
    }

    private void Create()
    {
        isWaitingToShoot = false;
        Instantiate(laserPrefab, new Vector3(transform.position.x, (transform.position.y - laserOffsetY), laserOffsetZ), Quaternion.identity);
    }
}
