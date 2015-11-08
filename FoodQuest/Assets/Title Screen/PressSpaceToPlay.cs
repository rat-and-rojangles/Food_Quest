using UnityEngine;
using System.Collections;

public class PressSpaceToPlay : MonoBehaviour {

	private bool movingOn = false;


	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			movingOn=true;
		}
		if (movingOn && gameObject.GetComponent<FadeToBlack> ().fullyFaded) {
			Application.LoadLevel("Area");
		}
	}
}
