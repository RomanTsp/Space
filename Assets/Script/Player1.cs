﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Player1: MonoBehaviour
{

    Rigidbody2D rigidBody;
    public float moveSpeed = 3f;
    public float JumpSpeed = 100f;
    public bool facingRight = true;
    Animator anim;
    bool isGrounded = false;
    bool healh;
    public Transform groundCheck;

    float groundRadius = 0.2f;
    public LayerMask whatIsGround;

    public float spawnX, spawnY;





    void Start()
    {
        spawnX = transform.position.x;
        spawnY = transform.position.y;

        anim = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Run();
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        anim.SetBool("Ground", isGrounded);
        anim.SetFloat("vSpeed", rigidBody.velocity.y);
        if (!isGrounded)
            return;

    }



    public void Run()
    {
        float move = Input.GetAxis("Horizontal");//рух от 0 до 1 або от 0 до -1 (рух в право або в ліво )
        anim.SetFloat("Speed", Mathf.Abs(move));
        rigidBody.velocity = new Vector2(move * moveSpeed, rigidBody.velocity.y); // 
        if (move > 0 && !facingRight)// обертаня персонажа в сторону руху
            Flip();
        else if (move < 0 && facingRight)
            Flip();
    }
    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);// перевертання персонажа по ос
    }

    public void Update()
    {
        
        if (isGrounded && Input.GetButtonDown("Jump"))//"))//якщо нажата кнопка Jump то відбудеться наступна дія ...
        {
            anim.SetBool("Ground", false);
            rigidBody.AddForce(new Vector2(0, 2000));//сила стрибка 
        }


    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("life"))
        {

            GetComponent<heals>().health += 1;
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "NextLevel")
        {
            SceneManager.LoadScene("Level3");
        }
        if (col.gameObject.name.Equals("Next"))

            SceneManager.LoadScene("Level4");

        if (col.gameObject.name.Equals("Next5"))

            SceneManager.LoadScene("level5");


    }


    void OnCollisionEnter2D(Collision2D col)
    {


        if (col.gameObject.tag == "EnemyShipTag" || col.gameObject.tag == "Boss")
            GetComponent<heals>().health -= 1;

        if (col.gameObject.tag == "EnemyBulletTag")
            GetComponent<heals>().health -= 1;



        if (col.gameObject.name == "colaider" || col.gameObject.name == "colaider1")
            transform.position = new Vector3(spawnX, spawnY, transform.position.z);


        if (col.gameObject.name.Equals("tiles"))
        {
            this.transform.parent = col.transform;
        }

    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("tiles"))
        {
            this.transform.parent = null;
        }



    }

}




