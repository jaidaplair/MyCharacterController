using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoving : MonoBehaviour
{
    [SerializeField] float speed = 4f;
    //[SerializeField] GameObject bulletPrefab;
    //private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
         Destroy(gameObject, 2f);
        // Set bullet's initial velocity based on player's facing direction
       // Rigidbody2D rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
       // Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //if (GameObject.FindWithTag("Player").GetComponent<SpriteRenderer>().flipY)
          //  rb.velocity = Vector2.left * speed;
        //if (GameObject.FindWithTag("Player").GetComponent<SpriteRenderer>().flipX)
           // rb.velocity = Vector2.right * speed;
       // if (GameObject.FindWithTag("Player").GetComponent<SpriteRenderer>().flipY)
         //   rb.velocity = Vector2.up * speed;
       // if (GameObject.FindWithTag("Player").GetComponent<SpriteRenderer>().flipX)
            //rb.velocity = Vector2.down * speed;
        // Destroy bullet when it goes out of the screen
        // if (!GetComponent<Renderer>().isVisible)
        // {
        //     Destroy(gameObject);
        // }

            transform.Translate(Time.deltaTime * speed* Vector3.right);
            //transform.Translate(direction * Time.deltaTime * speed );

    }


    /* private void OnTriggerEnter2D(Collider2D collision)
     {   //find and return the first object you see with a gamemanager component in it
         // GameManager gm;
         //  gm = FindAnyObjectByType<GameManager>();
         if (Input.GetKey(KeyCode.Space))
         {
             Instantiate(bulletPrefab, transform.position, transform.rotation);
         }*/
    /*  if (collision.CompareTag("BadGuy") == true)
      {   //increment score
          gm.score += 10;

      }
      if (collision.CompareTag("GoodGuy") == true)
      {   //decrement score
          gm.score -= 15;

      }*/
    //Instantiate(bulletPrefab, transform.position, transform.rotation);



    //Destroy(collision.gameObject);//destroy object we hit
    //Destroy(gameObject);//destroy the fireball
    //destroy ketchup
    //Debug.Log("Ive been triggered!!!!!!!!!"+ collision.name);

}

