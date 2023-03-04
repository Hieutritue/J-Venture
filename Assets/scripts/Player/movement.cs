using UnityEngine;

public class movement : MonoBehaviour
{
    private float horizontal;
    [SerializeField] private float speed = 3f;
    [SerializeField] private float jumpingPower = 8f;
    private bool isFacingRight = true;
    [SerializeField] Animator anim;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] LayerMask bounceLayer;
    [SerializeField] LayerMask enemyLayer;
    [SerializeField] private AudioSource jumpSoundEffect;

    
    
    
  private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("JumpTrap"))
        {
            jumpingPower = 20f;
        }
        if (collision.gameObject.CompareTag("resetJumpower"))
        {
            jumpingPower = 8f;
        }
        
    }
    
    void Update()
    {   
        horizontal = Input.GetAxisRaw("Horizontal");
        anim.SetFloat("speed",Mathf.Abs(horizontal));
        if(PauseMenu.isPaused==false)
        {
            if(Input.GetKeyDown(KeyCode.F)) 
                {
                    Fart();
                }
            if (Input.GetButtonDown("Jump") && IsGrounded())
            {
                Jump();
            }
        }
        if(onBounce())
        {
            Jump();
        }
        
        if(!IsGrounded())  {anim.SetBool("jumping",true);}
        if(IsGrounded()) {anim.SetBool("jumping",false);}
        

        Flip();
    }
    void Fart()
    {
        anim.SetTrigger("fart");
        
    }
    public void Jump()
    {
        jumpSoundEffect.Play();
        if (rb.gravityScale > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }
        if(rb.gravityScale < 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, -jumpingPower);
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    public bool OnEnemy()
    {
        return Physics2D.OverlapCircle(groundCheck.position,0.2f, enemyLayer);
    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    bool onBounce()
    {
        return Physics2D.OverlapCircle(groundCheck.position,0.2f, bounceLayer);
    }
    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}