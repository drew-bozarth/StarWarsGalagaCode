using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtons : MonoBehaviour
{
    public MainMenuSounds MainMenuSounds;


    public void OnR2D2ButtonPressed()
    {
        MainMenuSounds.PlayR2D2Sound();
    }

    public void OnStormTrooperButtonPressed()
    {
        MainMenuSounds.PlayStormTrooperSound();
    }

    public void OnYodaButtonPressed()
    {
        MainMenuSounds.PlayYodaSound();
    }

    public void OnKyloRenButtonPressed()
    {
        MainMenuSounds.PlayKyloRenSound();
    }

    public void OnStarWarsButtonPressed()
    {
        MainMenuSounds.PlayThemeSong();
    }

    public void OnStartButtonPressed()
    {
       MainMenuSounds.PlayStartSound();
    }

    public void PlaySoundWhenPlayerDies()
    {
        MainMenuSounds.PlayChewbaccaSound();
    }

    public void PlayCreditsSound()
    {
        MainMenuSounds.PlayCredits();
    }

    public void PlayDarthVaderSound()
    {
        MainMenuSounds.PlayDarthVader();
    }

    public void PlayLukeSkyWalkerSound()
    {
        MainMenuSounds.PlayLukeSkyWalker();
    }

    public void PlayThankYou()
    {
        MainMenuSounds.PlayThankYouJon();
    }

    public void PlayJawa1Sound()
    {
        MainMenuSounds.PlayJawa1();
    }

    public void PlayJawa2Sound()
    {
        MainMenuSounds.PlayJawa2();
    }

    public void PlayJawa3Sound()
    {
        MainMenuSounds.PlayJawa3();
    }

    public void PlayLightSabersSound()
    {
        MainMenuSounds.PlayLightSabers();
    }

}
