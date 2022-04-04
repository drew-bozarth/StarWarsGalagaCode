using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEffectObject : MonoBehaviour
{
    public GameObject DestroyParticleEffect;

    public void CreateDeathEffect()
    {
        Instantiate(DestroyParticleEffect, transform.position, Quaternion.identity);
    }
}
