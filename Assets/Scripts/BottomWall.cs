using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomWall : MonoBehaviour
{
    public PlayerShip PlayerShip;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerShip" || collision.gameObject.tag == "Laser")
        {
            return;
        }
        PlayerShip.DamageShip();
    }
}
