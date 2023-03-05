using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameController gameControllerScript;
    [SerializeField] GameObject transitionCanvas;
    // Start is called before the first frame update
    private void Awake() {
        gameControllerScript=GameObject.Find("main").GetComponent<GameController>();
    }
    public void NewGame()
    {   transitionCanvas.SetActive(true);
        SavePlayerPref.Reset();
        gameControllerScript.NextLevel();
    }
    public void Continue()
    {

    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}

