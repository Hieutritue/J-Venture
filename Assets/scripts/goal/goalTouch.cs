using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalTouch : MonoBehaviour
{   
    [SerializeField] GameController gameControllerScript;
    private void Awake() {
        gameControllerScript = GameObject.Find("main").GetComponent<GameController>();
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag=="Player")
            {
                gameControllerScript.NextLevel();
            }
    }
}
