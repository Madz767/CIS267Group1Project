using UnityEngine;

public class AlarmMovement : MonoBehaviour
{
    private Rigidbody2D arb;
    public float speed;
    private bool facingRight;
    private float direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        arb = GetComponent<Rigidbody2D>();
        direction = 1;
    }


    private void FixedUpdate()
    {
        arb.linearVelocity = new Vector2(direction * speed, arb.linearVelocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //this is used to flip the direction of the phone
        //when it hits one of the corral triggers
        //this will be for when the enemy sees the player
        if (collision.CompareTag("Player"))
        {
            //this stops the enemy for any 
            //actions they may take
            speed *= 0;


        }
        else if (collision.CompareTag("Corral") && facingRight)
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

    private void OnTriggerExit2D(Collider2D collision)
    {
        //this will make the enemy move once
        //the player is out of sight
        if (collision.CompareTag("Player"))
        {
            speed += 1;
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
