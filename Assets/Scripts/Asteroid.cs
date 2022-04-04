using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : DeathEffectObject
{
    public GameObject FloatingScorePrefab;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Laser")
        {
            CreateDeathEffect();
            Instantiate(FloatingScorePrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Game.Instance.AsteroidShot();
        }
        else
        {
            CreateDeathEffect();
            Destroy(gameObject);
            Game.Instance.AsteroidBreak();
        }
    }
}
