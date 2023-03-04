using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapfall : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private bool isTriggered = false;

    float check;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.isKinematic = true; // Vô hiệu hóa tính năng Rigidbody2D của trap
        float check = transform.position.y-1;
        }

        void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && !isTriggered)
        {
            rb2d.isKinematic = false; // Kích hoạt lại tính năng Rigidbody2D của trap
            rb2d.AddForce(new Vector2(0, -10), ForceMode2D.Impulse);
            isTriggered = true;
        }
    }
     private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Untagged"))
        Destroy(gameObject);
    }
}


