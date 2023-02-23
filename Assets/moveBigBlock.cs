using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBigBlock : MonoBehaviour
{
    bool inRange=false;
    bool movedLeft=false;
    float timer=0f;
    [SerializeField] LayerMask player;
    void Update()
    {
        inRange=Physics2D.OverlapCircle(transform.position,5.5f,player);
        if(inRange&&transform.position.x>=-80f&&!movedLeft)
            {
                transform.Translate(Vector3.left*18f*Time.deltaTime);Debug.Log("lp");
            }
        if(transform.position.x<=-79.5f) 
            movedLeft=true;
    }
    private void OnTriggerStay2D(Collider2D other) {
        if(other.CompareTag("Player")&&timer>=1f&&transform.position.x<=-75f)
        {
            transform.Translate(Vector3.right*18f*Time.deltaTime);
            
            Debug.Log("kokok");
        }
        timer+=Time.deltaTime;
    }
}
