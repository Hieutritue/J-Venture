using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class huuProjectile : MonoBehaviour
{
     float MoveSpeed = 2f;
 
      float frequency = 2f;  // Speed of sine movement
      float magnitude = 6f;   // Size of sine movement
     private Vector3 axis;
 
     private Vector3 pos;
 
     void Start () {
         pos = transform.position;
         axis = transform.up;  // May or may not be the axis you want
         
     }
     
     void Update () {
        if(transform.position.x<=-23f) Destroy(gameObject);
         pos -= transform.right * Time.deltaTime * MoveSpeed;
         transform.position = pos + axis * Mathf.Sin (Time.time * frequency) * magnitude;

     }
 
}
