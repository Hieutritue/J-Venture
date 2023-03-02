using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class binhSpawner : MonoBehaviour
{
    [SerializeField] GameObject binh;
    float rand;
    float timer =0f;
    float coolDown=5f;
    // Update is called once per frame
    void Update()
    {   rand= Random.Range(-10,5);
         coolDown+=Time.deltaTime;
        timer+=Time.deltaTime;
        if(coolDown>=15f&&coolDown<=24f)
            {
                Spawn();
                
            }
        if(coolDown>21f) coolDown=0f;
    }
    void Spawn()
    {   if(timer>=2f)
        {Instantiate(binh,new Vector2(transform.position.x,transform.position.y+rand),Quaternion.identity);
        timer=0f;}
    }
}
