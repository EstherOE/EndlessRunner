using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    
    CharacterController controller;
    Animator anime;
    Rigidbody2D body;
    private Vector3 moveVector;
    public float speed = 5;
    public float jumpSpeed = 3;
   public bool isGround;
    public LayerMask whatisGround;
    private Collider2D collider;

    public float jumpTime;
    private float jumpTimeCounter;

    public Vector2 respawnPoint;
    GameManager manager;
    Coins objCoins;
    // Start is called before the first frame update
    void Start()
    {
       anime= GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
        manager = FindObjectOfType<GameManager>();
        jumpTimeCounter = jumpTime;
        sm = FindObjectOfType<ScoreManager>();
        respawnPoint = transform.position;
        objCoins = FindObjectOfType<Coins>();
    }
    public bool blockRotationPlayer;

    // Update is called once per frame
    void Update()
    {
        if (gameOver == false)
        {
            isGround = Physics2D.IsTouchingLayers(collider, whatisGround);
            // float inputx = Input.GetAxis("Vertcal");
            body.velocity = new Vector2(speed, body.velocity.y);



            if (Input.GetKeyDown(KeyCode.Space) && isGround)
            {

                body.velocity = new Vector2(body.velocity.x, jumpSpeed);

            }

            if (Input.GetKey(KeyCode.Space))
            {
                if (jumpTimeCounter > 0)
                {
                    body.velocity = new Vector2(body.velocity.x, jumpSpeed);
                    jumpTimeCounter -= Time.deltaTime;

                }
            }
            anime.SetFloat("Speed", body.velocity.x);
            anime.SetBool("isGround", isGround);

        }
    }
    public bool gameOver = false;

    ScoreManager sm;

    public void  OnTriggerEnter2D( Collider2D othern)
    {
        if(othern.tag =="Death")
        {

            sm.Death();
            manager.gameOver();
            gameOver = true;
         }

        if(othern.tag =="Coin")
        {
            sm.GetScore(5);
            Destroy(othern.gameObject);
        }
        if(othern.tag=="Diamond")
        {
            sm.GetScore(20);
            Destroy(othern.gameObject);
        }
        
    }
  
    }


