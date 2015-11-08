using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class registerWithKillzone : MonoBehaviour {
    private static GameObject killCollider = null;
	void Start () {
        killCollider = killCollider ?? (GameObject.FindGameObjectWithTag("killcollider"));
        killCollider.SendMessage("register", gameObject);
    }
}
