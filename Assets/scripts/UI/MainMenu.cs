using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameController gameControllerScript;
    [SerializeField] GameObject transitionCanvas;
    [SerializeField] AudioSource clickSFX;
    // Start is called before the first frame update
    private void Awake() {
        gameControllerScript=GameObject.Find("main").GetComponent<GameController>();
    }
    public void NewGame()
    {   
        clickSFX.Play();
        transitionCanvas.SetActive(true);
        SavePlayerPref.Reset();
        gameControllerScript.NextLevel();
    }
    public void Continue()
    {   clickSFX.Play();
        transitionCanvas.SetActive(true);
        // if(PlayerPrefs.GetInt("level")==0)
        //     gameControllerScript.LoadLevel(PlayerPrefs.GetInt("level")+1);
        // else
            gameControllerScript.LoadLevel(PlayerPrefs.GetInt("level"));
    }
    public void QuitGame()
    {   
        clickSFX.Play();
        Debug.Log("QUIT");
        Application.Quit();
    }
}

