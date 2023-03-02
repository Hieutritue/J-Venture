using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introWolf : StateMachineBehaviour
{
  
    [SerializeField] AudioSource growl;
    float timer=0;
    bool isGrowling=false;
   [SerializeField] binhSpawner binh;
    [SerializeField] huuSpawner huu;
     // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
      
       
       growl=GameObject.Find("wolfboss").GetComponent<AudioSource>();
       huu=GameObject.Find("huuSpawner").GetComponent<huuSpawner>();
       binh=GameObject.Find("binhSpawner").GetComponent<binhSpawner>();
       huu.enabled=false;
       binh.enabled=false;
       
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       timer+=Time.deltaTime;
       if(timer>=2.8f&&!isGrowling)
            {
            isGrowling=true;
            Debug.Log("yes");
            growl.Play();
            }
            
    }
    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
