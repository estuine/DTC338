using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour {

    public float thrust;
    public string msg;

    private Rigidbody rb;
    private bool ground;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
        ground = false;
	}

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Terrain")
        {
            ground = true;
        }
    }

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Terrain")
        {
            ground = false;
        }
    }

        // Update is called once per frame
        void Update () {
        if (Input.GetKeyDown(KeyCode.Space)&&ground)
        {
            print(msg);
            rb.AddForce(transform.up * thrust);
        }
    }
}
