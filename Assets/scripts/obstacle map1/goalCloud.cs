using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalCloud : MonoBehaviour
{
    public float raiseSpeed = 8f;
    private float pause;

    [SerializeField] private bool isRaising = false;
    private void Start()
    {
        pause = transform.position.y + 5;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isRaising)
        {
            isRaising = true;
        }
    }
    
     

    private void FixedUpdate()
    {
        if (isRaising && transform.position.y <= pause )
        {
            transform.Translate(Vector2.up * raiseSpeed * Time.fixedDeltaTime);
        }
    }
}
