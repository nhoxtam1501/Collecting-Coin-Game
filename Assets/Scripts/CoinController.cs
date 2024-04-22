using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class CoinController : MonoBehaviour
{
    public float rotateSpeed = 1f;
   

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
       

    }

}
