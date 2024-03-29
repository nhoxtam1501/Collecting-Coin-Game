using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public float rotateSpeed = 1f;
    private static int coinCollected = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        transform.Rotate(rotateSpeed, 0, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {   
            coinCollected++;
            Destroy(gameObject);
            print("Collected " + coinCollected + " coin");
        }

    }

}
