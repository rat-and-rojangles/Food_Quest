using UnityEngine;
using System.Collections;

public class showJumpHint : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Renderer>().enabled = false;
	}
	
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "CharacterRobotBoy")
        {
            gameObject.GetComponent<Renderer>().enabled = true;
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
