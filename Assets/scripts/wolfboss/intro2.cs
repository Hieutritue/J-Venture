using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro2 : StateMachineBehaviour
{
    [SerializeField] AudioSource growl;
    [SerializeField] binhSpawner binh;
    [SerializeField] huuSpawner huu;
 
     // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       
       growl=GameObject.Find("wolfboss").GetComponent<AudioSource>();
       
       growl.Play();
       huu=GameObject.Find("huuSpawner").GetComponent<huuSpawner>();
       binh=GameObject.Find("binhSpawner").GetComponent<binhSpawner>();
       huu.enabled=true;
       binh.enabled=true;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    // override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    // {
    //    timer+=Time.deltaTime;
    //    if(timer>=2.8f&&!isGrowling)
    //         {
    //         isGrowling=true;
    //         Debug.Log("yes");
    //         growl.Play();
    //         }
            
    // }
}
