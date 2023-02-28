using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapDXQ : MonoBehaviour
{
    public float amp;
    public float freq;
    Vector3 initpos;

    private void Start()
    {
        initpos= transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position= new Vector3(initpos.x,Mathf.Sin(Time.time*freq)*amp+initpos.y,0);
    }
}
