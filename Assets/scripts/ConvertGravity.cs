using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertGravity : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameObject Player;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Convert_Bl"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y+3);
            transform.rotation = Quaternion.Euler(transform.rotation.x +180,0,0);
            rb.velocity = new Vector2(rb.velocity.x,0);
            rb.gravityScale = -rb.gravityScale;
        }
        if (collision.gameObject.CompareTag("Reverse Gravity"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 3);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.gravityScale = -rb.gravityScale;
        }
    }

}
