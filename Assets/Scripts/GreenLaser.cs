using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenLaser : DeathEffectObject
{
    public void OnCollisionEnter(Collision collision)
    {
        CreateDeathEffect();
        Destroy(gameObject);
        Game.Instance.GreenLaserBreak();
    }
}
