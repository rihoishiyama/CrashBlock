using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public GameObject gameClear;

    public float speed = 20.0f;

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(-1.0f, 0.0f, 1.0f) * speed);
	}
	
	// Update is called once per frame
    void Update () {
        if (GameObject.FindGameObjectsWithTag("Block").Length == 0)
        {
            gameClear.SetActive(true);
            Destroy(this.gameObject);
        }
	
    }
}
