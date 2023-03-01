using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class huuSpawner : MonoBehaviour
{
    [SerializeField] GameObject huu;
    float timer=0;
    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if(timer>=13f)
            {
                    Spawn();
                    timer=0f;
            }
    }
    void Spawn()
    {
        Instantiate(huu,new Vector2(transform.position.x,transform.position.y),Quaternion.identity);
    }
}
