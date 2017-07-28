using UnityEngine;
using System.Collections;

public class Racket : MonoBehaviour {

    public float accel = 100000.0f;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>(); 
	
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        rb.AddForce(new Vector3(horizontal, 0.0f, 0.0f) * accel);
	}
}
