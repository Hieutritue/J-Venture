using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl2 : MonoBehaviour
{
    [SerializeField] private Transform player;

    private void Update()
    {
        if(player.position.x >= 11.5)
        {
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
        }
        if(player.position.x <= 1.6 ){
        
            transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
        }
        if(player.position.y <=-7.65) {
            transform.position = new Vector3(player.position.x, player.position.y+4, transform.position.z);
        }
    }
}

