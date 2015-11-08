using UnityEngine;
using System.Collections;

public class pizzaEffect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "CharacterRobotBoy")
            Destroy(gameObject);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
