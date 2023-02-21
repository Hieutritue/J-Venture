using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyfall : MonoBehaviour
{

    private void OnTriggerEnter2D()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
    }

}
