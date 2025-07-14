using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float inputX;
    private int maxJumps;
    private float numJumps;
    private int level;

    public float speed;
    public float jumpForce;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        maxJumps = 2;
        numJumps = 1;
        level = 0;

    }

    // Update is called once per frame
    void Update()
    {
        playerMovementX();
        jump();

    }


    private void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && numJumps <= maxJumps)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocityX, jumpForce);
            numJumps++;
        }

    }

    private void playerMovementX()
    {
        inputX = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(speed * inputX, rb.linearVelocity.y);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            numJumps = 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("portal"))
        {
            if(level == 0)
            {
                SceneManager.LoadScene("Level1");
            }
            if (level == 1)
            {
                SceneManager.LoadScene("Level2");
            }
            if (level == 2)
            {
                SceneManager.LoadScene("Level3");
            }
            if (level == 3)
            {
                //you win!!
            }

        }
        
    }

}
