using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private Rigidbody2D rb;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("Item"))
        {
            Destroy(collision.gameObject);
        }
       if(collision.CompareTag("Key"))
        {
            Destroy(collision.gameObject);
        }
    }




}
