using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] AudioSource onClickSound;
    [SerializeField] GameController gameController;
    [SerializeField] TextMeshProUGUI textDeath;
    int i=0;
    private void Awake() {
        onClickSound.ignoreListenerPause=true;
        gameController=GameObject.Find("main").GetComponent<GameController>();
        textDeath.text="Deaths: " + PlayerPrefs.GetInt("deathNum");
    }
    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            {
                if(isPaused) 
                    {
                        Continue();
                    }
                else
                    {
                        Pause();
                    }
            }
        
    }

    void Pause()
    {   onClickSound.Play();
        AudioListener.pause=true;
        pauseMenu.SetActive(true);
        Time.timeScale=0f;
        isPaused=true;
    }
    public void Continue()
    {   onClickSound.Play();
        AudioListener.pause=false;
        pauseMenu.SetActive(false);
        Time.timeScale=1f;
        isPaused=false;
    }
    public void Quit()
    {   
        Time.timeScale=1f;
        AudioListener.pause=false;
        onClickSound.Play();
        pauseMenu.SetActive(false);
        gameController.LoadLevel(i);
        isPaused=false;
    }
}
