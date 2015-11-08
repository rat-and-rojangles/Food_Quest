using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class FallOutOfBounds : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name=="CharacterRobotBoy")
        {
            other.gameObject.transform.position = other.gameObject.GetComponent<PlatformerCharacter2D>().m_LastCheckpoint.transform.position;
            /*foreach(GameObject go in other.gameObject.GetComponent<PlatformerCharacter2D>().usedItems)
            {
                go.GetComponent<Renderer>().enabled = true;
            }*/
            other.gameObject.GetComponent<PlatformerCharacter2D>().usedItems.Clear();
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
