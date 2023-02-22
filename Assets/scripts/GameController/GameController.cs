using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject sceneTransition;
    [SerializeField] Transition transitionScript;
    void Awake() 
    {
        sceneTransition=GameObject.Find("SceneManager");
        transitionScript=sceneTransition.GetComponent<Transition>();
    }
    public void RestartLevel()
    {
        transitionScript.ReloadCurrentLevel();
    }
}
