using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AUV_Controller : MonoBehaviour
{
    public float speed = 50;
    public float torque = 10;
    //public GameObject Left_thruster;
    //public GameObject Right_thruster;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Left_thruster.AddForce(transform.forward * 500);
        float moveHorizantal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        //Freeze rotation 
        rb.freezeRotation = true;
        //Rotating Player
        //transform.Rotate(0, moveHorizantal, 0);

        Vector3 movement = new Vector3(moveHorizantal, 0, moveVertical);
        rb.AddForce(movement * speed );

        //rb.AddTorque(transform.up * moveHorizantal);
        //if(Input.GetKey(KeyCode.Q))
        //    rb.AddTorque(Vector3.right * speed * Time.deltaTime);
        //if (Input.GetKey(KeyCode.E))
        //    rb.AddTorque(-Vector3.right * speed * Time.deltaTime);


    }
}
