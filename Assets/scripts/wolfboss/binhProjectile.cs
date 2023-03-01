using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class binhProjectile : MonoBehaviour
{

    void Update()
    {   
        if(transform.position.y<=-14f) Destroy(gameObject);
        transform.Translate(new Vector2(3f,-2f)*Time.deltaTime);
    }
}
