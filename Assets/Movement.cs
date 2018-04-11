using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 5f; //The speed at which this object moves

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 curPosition = this.transform.position;

        Vector3 translation = Vector3.zero; //new Vector3(0,0,0);

        translation.x = Input.GetAxis("Horizontal"); //Move left/right with a or d
        translation.z = Input.GetAxis("Vertical"); //Move up/down with w or s

        this.transform.position = curPosition + translation * Time.deltaTime * speed;

	}

    private void OnCollisionEnter(Collision collision) {

        Debug.Log("You are died");

        Destroy(this.gameObject);

       
    }
}
