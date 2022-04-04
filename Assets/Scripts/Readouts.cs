using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Readouts : MonoBehaviour
{

    public Text Score;
    public Text Level;
    public Text Health;
    public Text GameResult;

    public Sounds Sounds;

    public void Reset()
    {
        ShowScore(0);
        ShowLevel(1);
        ShowHealth(100);
        HideWinResult();
    }

    public void ShowScore(int score)
    {
        if (score < 0)
            score = 0;
        Score.text = "Score: " + score;
    }

    public void ShowLevel(int levelNumber)
    {
        if (levelNumber < 1)
            levelNumber = 1;
        if (levelNumber < 5)
            Level.text = "Level: " + levelNumber;
    }

    public void ShowHealth(int health)
    {
        if (health < 0)
            health = 0;
        Health.text = "Health: " + health + "%";
    }

    public void ShowWinResult()
    {
        GameResult.text = "WINNER\n\nPress R to Restart Game";
    }

    public void ShowLoseResult()
    {
        GameResult.text = "LOSER\n\nPress R to Restart Game";
    }

    public void HideWinResult()
    {
        GameResult.text = "";
    }
}
