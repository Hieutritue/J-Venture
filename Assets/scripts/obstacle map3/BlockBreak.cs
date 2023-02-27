using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlockBreak : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Invoke("BreakBlock", 2);
        Invoke("RecreateBlock", 4);
    }
    
    private void BreakBlock()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;

    }

    private void RecreateBlock()
    {
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<BoxCollider2D>().enabled = true;
    }
}
