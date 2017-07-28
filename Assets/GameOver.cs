using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

    public GameObject gameOver;

    public GameObject explotionPlefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col){
        Destroy(col.gameObject);
        gameOver.SetActive(true);
        Instantiate(explotionPlefab, col.gameObject.transform.position, Quaternion.identity);
    }
}
