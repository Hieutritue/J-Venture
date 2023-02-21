using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
  [SerializeField] Animator anim;
    movement playerMovement;
    float countHurtTime=0f;
    void Start()
    {   
        playerMovement=gameObject.GetComponent<movement>();
    }


    void OnTriggerEnter2D(Collider2D collision)
    {   
        // BOSS SECTION*************************************************
        if(collision.CompareTag("enemy"))
            Debug.Log("hi");
        // END OF BOSS**************************************************
    }
    void OnCollisionEnter2D(Collision2D collision)
    {   // END OF BOSS**************************************************
        if(collision.gameObject.tag=="enemy" && playerMovement.OnEnemy())
           {countHurtTime+=1;
            if(countHurtTime>=20) anim.SetBool("phase2",true);
            anim.SetTrigger("hurt");
            playerMovement.Jump();
            Debug.Log(countHurtTime);
           }
        // END OF BOSS*************************************************
        
        // MINI GAME SECTION********************************************

        else if(collision.gameObject.CompareTag("Trap")){
                RestartLevel();
            Debug.Log("huhuhuhu");
        }
        // END MINI GAME
    }
     void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
