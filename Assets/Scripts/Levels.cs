using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    public Readouts Readouts;
    public List<GameObject> levels;
    private GameObject levelGameObject;
    private int currentLevel = 0;

    public void StartGame()
    {
        levelGameObject = CreateLevel();
        Readouts.ShowLevel(currentLevel + 1);
    }

    public void GoToNextLevel()
    {
        if (currentLevel < levels.Count)
            currentLevel++;
        if (IsGameOver())
            return;
        LoadNextLevel();
    }

    public bool IsGameOver()
    {
        if (currentLevel == levels.Count)
            return true;
        return false;
    }

    public void EndGame()
    {
        currentLevel = levels.Count - 1;
    }

    private void LoadNextLevel()
    {
        if (levelGameObject != null)
            Destroy(levelGameObject);
        levelGameObject = CreateLevel();
        Readouts.ShowLevel(currentLevel + 1);
    }

    private GameObject CreateLevel()
    {
        if (currentLevel < levels.Count)
            return Instantiate(levels[currentLevel], levels[currentLevel].transform.position, Quaternion.identity);
        else
            return null;
    }
}
