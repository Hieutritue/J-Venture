using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movedBL : MonoBehaviour
{
      public float Speed = 2f; 

    private bool isRaising = false; 
    private bool isOn = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isRaising)
        {
            isRaising = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag=="Player" && !isOn)
        {
            isOn = true;
        }
    }

    private void FixedUpdate()
    {
        if (isRaising && transform.position.x >=-17.2)
        {
            transform.Translate(Vector2.left * Speed * Time.fixedDeltaTime);
        }

        if( isOn && transform.position.x >=-34)
        {
            transform.Translate(Vector2.left * 1 * Time.fixedDeltaTime);
        }
    }
}
