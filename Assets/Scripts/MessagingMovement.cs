using UnityEngine;

public class MessagingMovement : MonoBehaviour
{

    private Rigidbody2D mrb;
    public float speed;
    private float direction;
    private bool facingRight;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mrb = GetComponent<Rigidbody2D>();
        direction = 1;
    }

    private void FixedUpdate()
    {
        mrb.linearVelocity = new Vector2(direction * speed, mrb.linearVelocity.y);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //this is used to flip the direction of the phone
        //when it hits one of the corral triggers
        if (collision.CompareTag("Player"))
        {
            //this will be used to create the
            //"bomb" that will be dropped



        }
        if (collision.CompareTag("Corral") && facingRight)
        {
            direction *= -1;
            changeDirection();
            facingRight = true;
        }
        else if (collision.CompareTag("Corral") && !facingRight)
        {
            direction *= -1;
            changeDirection();
            facingRight = false;
        }

    }



    private void changeDirection()
    {
        //Down here is the code for changing the direction
        //of the sprite
        if (facingRight)
        {
            Vector3 localscale = transform.localScale;
            localscale.x *= -1;
            transform.localScale = localscale;
        }
        else
        {
            Vector3 localscale = transform.localScale;
            localscale.x *= -1;
            transform.localScale = localscale;

        }

        //use this to help with any and all changes to direction for the sprite

    }
}
