using UnityEngine;
using System.Collections;

public class DestroySelfOnTouch : MonoBehaviour {


	//void OnCollision2D(){
	//	Destroy (this);
	//}

	void Update(){
		if (transform.position.y < -15) {
			Destroy (gameObject);
		}
	}
}
