using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapngocmai : MonoBehaviour
{
   public float Speed = 24f; 

    private bool isFalling = false; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isFalling)
        {
            isFalling = true;
        }
    }

    private void FixedUpdate()
    {
        if (isFalling && transform.position.y >=3.1)
        {
            transform.Translate(Vector2.down * Speed * Time.fixedDeltaTime);
        }
    }
}

