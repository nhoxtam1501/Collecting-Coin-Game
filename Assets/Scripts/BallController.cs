using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    public float speed = 6f;
    float xInput;
    float yInput;
    Rigidbody rb;

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
        xInput = Input.GetAxis("Horizontal") * speed;
        yInput = Input.GetAxis("Vertical") * speed;

        if (transform.position.y < -5f)
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, speed + 300f, 0);
        }
    }

    //fixed update is getting called after fixed amount of time
    private void FixedUpdate()
    {
        rb.AddForce(xInput, rb.velocity.y, yInput);
        //rb.velocity = new Vector3(xInput, rb.velocity.y, yInput);
    }

    
}
