using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCubeMoveScript : MonoBehaviour {

    public GameObject player; //a variable containing the player's cube
    public int speed; //just an example of how you can make a public speed variable that will show in the inspector

    Rigidbody rb;
    bool holdingD = false;
    bool holdingA = false;

    // Use this for initialization
    void Start()
    {

        Debug.Log("Hello World!");

        rb = this.GetComponent<Rigidbody>(); //Get the rigidbody associated with this object

    }

    // Update is called once per frame
    void Update()
    {

        //make the bot hold D if the player is to the right, otherwise hold A
        holdingD = player.transform.position.x > this.transform.position.x;
        holdingA = player.transform.position.x < this.transform.position.x;
    }
    // Update is called once per PHYSICS frame
    void FixedUpdate()
    {
        if (holdingD == true) //if holding D, make a force applying to the right
            rb.AddForce(new Vector3(20, 0, 0));

        if (holdingA == true) //if holding A, make a force applying to the left
            rb.AddForce(new Vector3(-20, 0, 0));

    }
}
