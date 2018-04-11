using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour {

    public float speed = 5f;

    public GameObject bucket;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (bucket == null)
        {
            return;
        }

        Vector3 curPosition = this.transform.position;

        Vector3 translation = Vector3.zero; //new Vector3(0,0,0);

        translation = -(curPosition - bucket.transform.position).normalized;

        this.transform.position = curPosition + translation * Time.deltaTime * speed;


    }
}
