using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSounds : MonoBehaviour
{

    public AudioSource AudioSource;

    public AudioClip ThemeSong;
    public AudioClip YodaSound;
    public AudioClip KyloRenSound;
    public AudioClip R2D2Sound;
    public AudioClip StormTrooperSound;
    public AudioClip StartSound;
    public AudioClip ChewbaccaSound;
    public AudioClip Credits;
    public AudioClip DarthVaderSound;
    public AudioClip LukeSkyWalkerSound;
    public AudioClip JonSound;
    public AudioClip FalconVTieSound;
    public AudioClip Jawa2;
    public AudioClip Jawa3;
    public AudioClip LightSabersSound;
    public AudioClip CantinaSound;



    public void PlayThemeSong()
    {
        AudioSource.clip = ThemeSong;
        AudioSource.Play();
    }

    public void PlayR2D2Sound()
    {
        AudioSource.clip = R2D2Sound;
        AudioSource.Play();
    }

    public void PlayYodaSound()
    {
        AudioSource.clip = YodaSound;
        AudioSource.Play();
    }

    public void PlayKyloRenSound()
    {
        AudioSource.clip = KyloRenSound;
        AudioSource.Play();
    }

    public void PlayStormTrooperSound()
    {
        AudioSource.clip = StormTrooperSound;
        AudioSource.Play();
    }

    public void PlayStartSound()
    {
        AudioSource.clip = StartSound;
        AudioSource.Play();
    }

    public void PlayCantinaSound()
    {
        AudioSource.clip = CantinaSound;
        AudioSource.Play();
    }

    public void PlayChewbaccaSound()
    {
        AudioSource.clip = StartSound;
        AudioSource.Play();
    }

    public void PlayCredits()
    {
        AudioSource.clip = Credits;
        AudioSource.Play();
    }

    public void PlayDarthVader()
    {
        AudioSource.clip = DarthVaderSound;
        AudioSource.Play();
    }

    public void PlayLukeSkyWalker()
    {
        AudioSource.clip = LukeSkyWalkerSound;
        AudioSource.Play();
    }

    public void PlayThankYouJon()
    {
        AudioSource.clip = JonSound;
        AudioSource.Play();
    }

    public void PlayJawa1()
    {
        AudioSource.clip = FalconVTieSound;
        AudioSource.Play();
    }

    public void PlayJawa2()
    {
        AudioSource.clip = Jawa2;
        AudioSource.Play();
    }

    public void PlayJawa3()
    {
        AudioSource.clip = Jawa3;
        AudioSource.Play();
    }

    public void PlayLightSabers()
    {
        AudioSource.clip = LightSabersSound;
        AudioSource.Play();
    }
}
