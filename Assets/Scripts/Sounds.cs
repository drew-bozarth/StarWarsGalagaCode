using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip FiringLaser;
    public AudioClip LaserHit;
    private AudioSource audioSource;
    public AudioClip ChewbaccaSound;
    public AudioClip CantinaSound;
    public AudioClip ImperialSound;
    public AudioClip LuckyWinSound;

    void Start()
    {
        audioSource = GameObject.FindGameObjectWithTag("AudioSource").GetComponent<AudioSource>();
    }

    public void PlayFiringLaser()
    {
        audioSource.PlayOneShot(FiringLaser);
    }

    public void PlayLaserHit()
    {
        audioSource.PlayOneShot(LaserHit);
    }

    public void ShipExplosion()
    {
        audioSource.PlayOneShot(LaserHit);
    }

    public void PlayChewbaccaSound()
    {
        audioSource.PlayOneShot(ChewbaccaSound);
    }

    public void PlayCantinaSound()
    {
        audioSource.PlayOneShot(CantinaSound);
    }

    public void PlayImperialSongWhenLose()
    {
        audioSource.PlayOneShot(ImperialSound);
    }

    public void PlayGameWinSound()
    {
        audioSource.PlayOneShot(LuckyWinSound);
    }

    public void StopSounds()
    {
        audioSource.Stop();
    }
}
