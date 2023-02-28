using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    [SerializeField] Animator wolfAnim;
    [SerializeField] AudioSource music;
    [SerializeField] AudioSource dieSFX;
    [SerializeField] Animator playerAnim;
    movement playerMovement;
    float countHurtTime = 0f;
    GameController gameControllerScript;
    Rigidbody2D rb;

    void Start()
    {
        gameControllerScript = gameObject.GetComponent<GameController>();
        playerMovement = gameObject.GetComponent<movement>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        playerAnim = gameObject.GetComponent<Animator>();
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        // BOSS SECTION*************************************************
        if (collision.CompareTag("enemy"))
            DieAndRestart();

        // END OF BOSS**************************************************
        if (collision.gameObject.CompareTag("checkpoint"))
        {
            CheckpointManager.SetCheckpoint(collision.transform.position);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // BOSS**************************************************
        if (collision.gameObject.tag == "enemy" && playerMovement.OnEnemy())
        {
            countHurtTime += 1;
            if (countHurtTime >= 20) wolfAnim.SetBool("phase2", true);
            wolfAnim.SetTrigger("hurt");
            playerMovement.Jump();
        }
        // END OF BOSS*************************************************

        // MINI GAME SECTION********************************************

        if (collision.gameObject.CompareTag("Trap"))
            DieAndRestart();

        // CONVERT GRAVITY************************************
        if (collision.gameObject.CompareTag("Convert_Bl"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 3);
            transform.rotation = Quaternion.Euler(transform.rotation.x + 180, 0, 0);
            rb.velocity = new Vector2(rb.velocity.x, 0);
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

    void DieAndRestart()
    {
        music.Stop();
        dieSFX.Play();
        playerAnim.SetTrigger("die");
        rb.bodyType = RigidbodyType2D.Static;
        gameControllerScript.RestartLevel();
    }
}