using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leduycuong : MonoBehaviour
{   
    [SerializeField] Transform player;
    [SerializeField] float speed=2f;
    [SerializeField] LayerMask playerLayer;
    public bool active=false;
    void Start()
    {
        active=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x-player.position.x<=7f) active=true;
        if(active)
        {
        transform.Translate(Vector3.left*speed*Time.deltaTime);
        transform.position=new Vector3(transform.position.x,player.position.y,transform.position.z);
        }
    }
}
