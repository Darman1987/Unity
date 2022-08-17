using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //it is posible make the variables public to test in unity with diferent values
    private float speed = 5.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {    // detect the inputs user  
        horizontalInput = Input.GetAxis("Horizontal"); //a,d or horizontal arrows
        forwardInput = Input.GetAxis("Vertical");// w,s or vertical arrows

        // Move the vehicle forward.
        //transform.Translate(0,0,1); the code below makes exactly the same that this line of code
        transform.Translate(Vector3.forward*Time.deltaTime * speed * forwardInput);//it runs speed times per second
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); car moves sliding
        //rotate the car base in horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput); // car moves rotaiting seing when axis rote when I rotate the vehicle manually
    }
}
