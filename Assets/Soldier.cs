using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float bulletSpeed = 4f;

    Animator animator;
    SpriteRenderer spriteRenderer;
    // Update is called once per frame

    void Start()
    {
        //reference to our animator component
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();//get a reference to our spriteRenderer

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("right", true);//set the right parametor to true
            spriteRenderer.flipX = false;// dont wanna flip
            transform.Translate(Time.deltaTime * speed * Vector3.right);

            // transform.Translate(transform.position);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("right", true);//set the right parameter top false
            spriteRenderer.flipX = true;//want ot flip
            transform.Translate(Time.deltaTime * speed * Vector3.left);
        }
        else
        {
            animator.SetBool("right", false);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("up", true);//set the up parametor to true
            transform.Translate(Time.deltaTime * speed * Vector3.up);
        }
        else
        {
            animator.SetBool("up", false);//set the up parameter top false
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("down", true);//set the down parametor to true
            transform.Translate(Time.deltaTime * speed * Vector3.down);
        }
        else
        {
            animator.SetBool("down", false);//set the down parameter top false
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            // Set bullet's velocity based on player's facing direction
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            if (transform.localScale.x > 0)
                rb.velocity = Vector2.right * bulletSpeed;
            else
                rb.velocity = Vector2.left * bulletSpeed;
        }
    }
}  
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
       // Destroy(gameObject);//destroy the fireball
                            //destroy ketchup
                            //Debug.Log("Ive been triggered!!!!!!!!!"+ collision.name);
    

