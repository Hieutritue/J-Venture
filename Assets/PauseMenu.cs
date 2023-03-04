using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] AudioSource onClickSound;
    private void Awake() {
        onClickSound.ignoreListenerPause=true;
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
    {   onClickSound.Play();
        Application.Quit();
    }
}
