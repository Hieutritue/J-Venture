using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalTouch : MonoBehaviour
{   
    [SerializeField] GameController gameControllerScript;
    [SerializeField] AudioSource winSFX;
    private void Awake() {
        winSFX=GameObject.Find("winSFX").GetComponent<AudioSource>();
        gameControllerScript = GameObject.Find("main").GetComponent<GameController>();
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag=="Player")
            {
                winSFX.Play();
                gameControllerScript.NextLevel();
            }
    }
}
