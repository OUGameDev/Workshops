using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoveScript : MonoBehaviour {

    Rigidbody rb;
    bool holdingD = false;
    bool holdingA = false;
    bool holdingW = false;

	// Use this for initialization
	void Start () {

        Debug.Log("Hello World!");

        rb = this.GetComponent<Rigidbody>(); //Get the rigidbody associated with this object

	}
	
	// Update is called once per frame
	void Update () {

        holdingD = Input.GetKey("d");
        holdingA = Input.GetKey("a");

        //make holdingW true on the first frame that w is pressed
        //keep it true until somewhere else sets it false
        holdingW = Input.GetKeyDown("w") || holdingW;

    }
    // Update is called once per PHYSICS frame
    void FixedUpdate()
    {
        if (holdingD == true)
            rb.AddForce(new Vector3(20, 0, 0));

        if (holdingA == true)
            rb.AddForce(new Vector3(-20, 0, 0));

        if (holdingW == true)
        {
            rb.AddForce(new Vector3(0, 300, 0));
            holdingW = false; //After a jump is triggered, set holdingW back to false
        }

    }
}
