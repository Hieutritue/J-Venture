using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HiddenSpike : MonoBehaviour
{
    public float raiseSpeed = 2f; 

    private bool isRaising = false; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isRaising)
        {
            GetComponent<SpriteRenderer>().enabled = true;
            isRaising = true;
        }
    }

    private void FixedUpdate()
    {
        if (isRaising && transform.position.y <=0.4)
        {
            transform.Translate(Vector2.up * raiseSpeed * Time.fixedDeltaTime);
        }
    }
}
