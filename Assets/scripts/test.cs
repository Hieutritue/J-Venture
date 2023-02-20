using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private float raiseSpeed = 1f;
    private bool isRaising = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (isRaising)
            {
                transform.Translate(Vector2.left * raiseSpeed * Time.fixedDeltaTime);
            }
        }
    }
}
