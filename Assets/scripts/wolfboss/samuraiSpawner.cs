using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class samuraiSpawner : MonoBehaviour
{   float timer=0;
    float coolDown=0;
    
    [SerializeField] GameObject khai;
    void Update()
    {   coolDown+=Time.deltaTime;
        timer+=Time.deltaTime;
        if(coolDown>=15f&&coolDown<=24f)
            {
                SpawnKhai();
                
            }
        if(coolDown>21f) coolDown=0f;
        
    }
    void SpawnKhai()
    {
        if(timer>=3f)
            {
                Instantiate(khai,new Vector2(transform.position.x,transform.position.y),Quaternion.identity);
                timer=0f;
            }
    }
}
