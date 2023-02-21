using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike1m2 : MonoBehaviour
{
    // Start is called before the first frame update
   public float Speed = 2f; 

    private bool isRaising = false; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isRaising)
        {
            isRaising = true;
        }
    }

    private void FixedUpdate()
    {
        if (isRaising && transform.position.y <=-1.15)
        {
            transform.Translate(Vector2.up * Speed * Time.fixedDeltaTime);
        }
    }
}
