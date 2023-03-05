using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalTouch : MonoBehaviour
{   
    [SerializeField] GameController gameControllerScript;
    [SerializeField] AudioSource winSFX;
    [SerializeField] Rigidbody2D rb;
    private void Awake() {
        rb=GameObject.Find("main").GetComponent<Rigidbody2D>();
        winSFX=GameObject.Find("winSFX").GetComponent<AudioSource>();
        gameControllerScript = GameObject.Find("main").GetComponent<GameController>();
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag=="Player")
            {   
                rb.bodyType=RigidbodyType2D.Static;
                winSFX.Play();
                gameControllerScript.NextLevel();
            }
    }
}
