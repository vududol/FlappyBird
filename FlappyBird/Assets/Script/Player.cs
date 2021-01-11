using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb2;
    public float JumpPower = 10f;

    //점수를 위해 게임매니저 스크립트를 소환
    public GameManager GM;

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2.velocity = Vector2.up * JumpPower;
        }

    }


    void OnTriggerExit2D (Collider2D collision)
    {
        if (collision.CompareTag("Score"))
        {
            GM.AddScore();
        }
    }

    //OnTrigger 는 Collider 를, OnCollision 은 Collision 을 받아온다
    private void OnCollisionEnter2D(Collision2D other)

    {

        //Debug.Log ("Wow");
        GM.isGameOver = true;
    }

}
