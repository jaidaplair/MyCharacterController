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
    bool right, left, up, down;
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
            right = true;
           
            left = false;
            up = false;
            down = false;

            // transform.Translate(transform.position);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("right", true);//set the right parameter top false
            spriteRenderer.flipX = true;//want ot flip
            transform.Translate(Time.deltaTime * speed * Vector3.left);
            left = true;
            right = false;
            
            up = false;
            down = false;
        }
        else
        {
            animator.SetBool("right", false);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("up", true);//set the up parametor to true
            transform.Translate(Time.deltaTime * speed * Vector3.up);
            up = true;
            right = false;
            left = false;
            
            down = false;
        }
        else
        {
            animator.SetBool("up", false);//set the up parameter top false
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("down", true);//set the down parametor to true
            transform.Translate(Time.deltaTime * speed * Vector3.down);
            down = true;
            right = false;
            left = false;
            up = false;
            
        }
        else
        {
            animator.SetBool("down", false);//set the down parameter top false
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
           // GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            if (left == true)
            {
                GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                bullet.transform.Rotate(0f, 0f, 180f);
                //transform.Translate(Time.deltaTime * speed * Vector3.left);
            }
            if (up == true)
            {
                GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                bullet.transform.Rotate(0f, 0f, 90f);
               // transform.Translate(Time.deltaTime * speed * Vector3.up);
            }
            if (down == true)
            {
                GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                bullet.transform.Rotate(0f, 0f, 270f);
               // transform.Translate(Time.deltaTime * speed * Vector3.down);
            }
            if (right == true)
            {
                GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
               // transform.Translate(Time.deltaTime * speed * Vector3.right);
            }
        }
        //instantiate the bullet

        //if player is pointing to right, dont rotate. if point up rotate by 90, left = 180, down = -90
        //bullet.transform.Rotate(90);
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            // Set bullet's velocity based on player's facing direction
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            if (transform.localScale.x > 0)
                rb.velocity = Vector2.right * bulletSpeed;
            else
                rb.velocity = Vector2.left * bulletSpeed;

            if (transform.localScale.y > 0)
                rb.velocity = Vector2.up * bulletSpeed;
            else
                rb.velocity = Vector2.down * bulletSpeed;
        }*/


    }
   


}




