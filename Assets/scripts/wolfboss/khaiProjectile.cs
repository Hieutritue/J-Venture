using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class khaiProjectile : MonoBehaviour
{
    
    void Update()
    {   if(transform.position.x<=-23f) Destroy(gameObject);
        transform.Translate(Vector3.left*4f*Time.deltaTime);
    }
}
