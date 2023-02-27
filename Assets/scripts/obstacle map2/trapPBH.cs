using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapPBH : MonoBehaviour
{
    public float Speed = 20f;

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
        if (isRaising && transform.position.x <= -43)
        {
            transform.Translate(Vector2.right * Speed *Time.fixedDeltaTime);
        }
    }
}
