using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static Game Instance;
    public Readouts Readouts;
    public PlayerShip PlayerShip;
    private Levels Levels;
    private int score;
    private bool gameLost;

    public Sounds Sounds;

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this.gameObject);
        else
            Instance = this;
        Levels = gameObject.GetComponent<Levels>();
    }

    private void Start()
    {
        Reset();
    }

    private void FixedUpdate()
    {
        CheckIfWon();
    }

    public void DisableGamePlay()
    {
        PlayerShip.Disable();
    }

    public void AsteroidShot()
    {
        UpdateScore(score + 10);
        CheckIfWon();
    }

    public void AsteroidBreak()
    {
        CheckIfGameOver();
        CheckIfWon();
    }

    public void TieFighterShot()
    {
        UpdateScore(score + 50);
        CheckIfWon();
    }

    public void TieFighterBreak()
    {
        CheckIfGameOver();
        CheckIfWon();
    }

    public void GreenLaserBreak()
    {
        CheckIfGameOver();
        CheckIfWon();
    }

    private void CheckIfGameOver()
    {
        if (PlayerShip.LifeRemaining == 0)
        {
            LoseGame();
            Levels.EndGame();

        }
    }

    private void CheckIfWon()
    {
        if (CountTieFighters() <= 0)
        {
            Levels.GoToNextLevel();
            if (Levels.IsGameOver() && !gameLost)
            {
                DisableGamePlay();
                WinGame();
            }
        }
    }

    private void WinGame()
    {
        Readouts.ShowWinResult();
    }

    private void LoseGame()
    {
        Readouts.ShowLoseResult();
        gameLost = true;
    }

    private void Reset()
    {
        score = 0;
        Readouts.Reset();
        gameLost = false;
    }

    private void UpdateScore(int newScore)
    {
        score = newScore;
        Readouts.ShowScore(score);
    }

    private int CountTieFighters()
    {
        return GameObject.FindGameObjectsWithTag("TieFighter").Length;
    }
}
