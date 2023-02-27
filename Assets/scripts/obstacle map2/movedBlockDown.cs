using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movedBlockDown : MonoBehaviour
{
    public float Speed = 2f;

    private bool isRaising = false;

     private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag=="Player" && !isRaising)
        {
            isRaising = true;
        }
    }

    private void FixedUpdate()
    {
        if (isRaising && transform.position.y >= -11)
        {
            transform.Translate(Vector2.down * Speed * Time.fixedDeltaTime);
        }
    }
}
