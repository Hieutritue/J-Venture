using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movedBlockDown : MonoBehaviour
{
    public float Speed = 2f;

    private bool isRaising = false;
    private bool isOn = false;

    private void OnCollisionEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isRaising)
        {
            isRaising = true;
        }
    }
    

    private void FixedUpdate()
    {
        if (isRaising && transform.position.y >= -10)
        {
            transform.Translate(Vector2.down * Speed * Time.fixedDeltaTime);
        }

        if (isOn && transform.position.y >= -28)
        {
            transform.Translate(Vector2.left * 2 * Time.fixedDeltaTime);
        }
    }
}
