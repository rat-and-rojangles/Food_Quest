using UnityEngine;
using System.Collections;

public class PressSpaceToPlay : MonoBehaviour {

	private bool movingOn = false;

	public FadeToBlack fader;


	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Application.LoadLevel("Area");
		}
	}
}
