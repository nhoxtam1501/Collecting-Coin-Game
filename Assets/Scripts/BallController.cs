using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Timeline.TimelinePlaybackControls;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public float speed = 6f;
    float xInput;
    float zInput;
    Rigidbody rb;
    private float jump = 200f;
    private bool canMove = true;

    private int coinCollected = 0;
    public GameObject winText;
    public Text scoreText;
    private int TOTAL_COIN = 3;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {




        if (transform.position.y < -5f)
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, speed + jump, 0);
        }
    }

    //fixed update is getting called after fixed amount of time
    private void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal") * speed;
        zInput = Input.GetAxis("Vertical") * speed;

        if (canMove)
        {
            rb.AddForce(xInput, rb.velocity.y, zInput);
            
        }
        else
        {
            rb.velocity = Vector3.zero;
           // transform.Rotate(Vector3.right * speed);

        }


        //rb.velocity = new Vector3(xInput, rb.velocity.y, yInput);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            coinCollected++;
            collision.gameObject.SetActive(false);
            scoreText.text = "Score: " + coinCollected.ToString();

            if (coinCollected == TOTAL_COIN)
            {
                winText.SetActive(true);
                canMove = false;
            }       
        }
    }

}
