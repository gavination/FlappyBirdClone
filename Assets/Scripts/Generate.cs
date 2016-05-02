using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

    public float range = 4;
    public GameObject obstacle;

	// Use this for initialization
	void Start () {

        InvokeRepeating("CreateObstacle", 1f, 1.5f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void CreateObstacle()
    {
        Vector3 obstacleLocale = new Vector3(10, transform.position.y - range * Random.value, 0);

        Instantiate(obstacle, obstacleLocale, Quaternion.identity);
    }
}
