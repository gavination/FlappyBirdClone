using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

    public Vector2 obstacleVelocity = new Vector2(-4, 0); 

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = obstacleVelocity;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
