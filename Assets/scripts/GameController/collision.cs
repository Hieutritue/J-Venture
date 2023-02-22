using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    [SerializeField] Animator anim;
    movement playerMovement;
    float countHurtTime=0f;
    GameController logic;
    Rigidbody2D rb;
    void Start()
    {   
        logic = gameObject.GetComponent<GameController>();
        playerMovement=gameObject.GetComponent<movement>();
        rb=gameObject.GetComponent<Rigidbody2D>();
    }


    void OnTriggerEnter2D(Collider2D collision)
    {   
        // BOSS SECTION*************************************************
        if(collision.CompareTag("enemy"))
            logic.RestartLevel();
        // END OF BOSS**************************************************
    }
    void OnCollisionEnter2D(Collision2D collision)
    {   // END OF BOSS**************************************************
        if(collision.gameObject.tag=="enemy" && playerMovement.OnEnemy())
           {countHurtTime+=1;
            if(countHurtTime>=20) anim.SetBool("phase2",true);
            anim.SetTrigger("hurt");
            playerMovement.Jump();
            
           }
        // END OF BOSS*************************************************
        
        // MINI GAME SECTION********************************************

        if(collision.gameObject.CompareTag("Trap")){
                logic.RestartLevel();
            
        }

          // CONVERT GRAVITY************************************
        if (collision.gameObject.CompareTag("Convert_Bl"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y+3);
            transform.rotation = Quaternion.Euler(transform.rotation.x +180,0,0);
            rb.velocity = new Vector2(rb.velocity.x,0);
            rb.gravityScale = -rb.gravityScale;
        }
        if (collision.gameObject.CompareTag("Reverse Gravity"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 3);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.gravityScale = -rb.gravityScale;
        }
          //END CONVERT GRAVITY********************************
        // END MINI GAME
    }
}
