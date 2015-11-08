using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class ChangeCheckPoint : MonoBehaviour {

    public bool visited = false;
	// Use this for initialization
	void Start () {
	
	}
	
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "CharacterRobotBoy" && !visited)
        {
            visited = true;
            other.gameObject.GetComponent<PlatformerCharacter2D>().m_LastCheckpoint = gameObject;
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
