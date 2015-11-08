using UnityEngine;
using System.Collections;

public class CrazySpawner : MonoBehaviour {

	public Object something;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float yee = Random.Range (0, 500);
		if (yee > 490) {
			//Instantiate(something, new Vector3( Random.Range (-360, 360), GetComponent<Transform>().position.y, 0), Quaternion.Euler(0,0,Random.Range (0, 360)));
			//Object ok = Instantiate(something,GetComponent<Transform>().position,Quaternion.Euler(0,0,Random.Range (0, 360)));
			Object ok = Instantiate(something);

		}

	}
}
