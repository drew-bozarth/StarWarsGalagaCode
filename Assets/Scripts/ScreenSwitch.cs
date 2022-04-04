using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSwitch : MonoBehaviour
{

    public GameObject MainGameObject;
    public GameObject PlayerShip;
    public CanvasGroup MainMenu;
    public CanvasGroup GameScreen;
    public Levels Levels;


    void Start()
    {
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        Hide(GameScreen);
        Show(MainMenu);
        PlayerShip.SetActive(false);
        MainGameObject.SetActive(false);
        Cursor.visible = true;
    }

    public void ShowGameScreen()
    {
        Hide(MainMenu);
        Show(GameScreen);
        Levels.StartGame();
        PlayerShip.SetActive(true);
        MainGameObject.SetActive(true);
    }

    private void Show(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
    }

    private void Hide(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }
}
