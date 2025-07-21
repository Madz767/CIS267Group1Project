using UnityEngine;
using UnityEngine.Android;

public class PhoneMovement : MonoBehaviour
{
    private Rigidbody2D prb;
    public float speed;
    private float direction;
    private bool facingRight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        prb = GetComponent<Rigidbody2D>();
        direction = 1;
    }


    private void FixedUpdate()
    {
        prb.linearVelocity = new Vector2(direction * speed, prb.linearVelocity.y);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //this is used to flip the direction of the phone
        //when it hits one of the corral triggers
        if (collision.CompareTag("Player"))
        {
            //this is used to stop the enemy
            //upon sight with the player
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
        //this is used to make the enemy move again
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
