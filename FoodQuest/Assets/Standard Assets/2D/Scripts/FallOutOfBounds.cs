using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;
using System.Collections.Generic;

public class FallOutOfBounds : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    private List<GameObject> registeredGOs = new List<GameObject>();
    private List<Vector3> posMemento = new List<Vector3>();
    private List<Quaternion> rotMemento = new List<Quaternion>();
    private List<bool> kinematics = new List<bool>();


    public void register(Object param)
    {
        var go = ((GameObject)param);
        registeredGOs.Add(go);
        kinematics.Add(go.GetComponent<Rigidbody2D>().isKinematic);
        posMemento.Add(go.transform.position);
        rotMemento.Add(go.transform.rotation);
    }

    private void resetRegistered()
    {
        for(int i = 0; i < registeredGOs.Count; ++i)
        {
            var go = registeredGOs[i];
            var t = go.transform;

            go.GetComponent<Rigidbody2D>().isKinematic = kinematics[i];
            t.position = posMemento[i];
            t.rotation = rotMemento[i];
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name=="CharacterRobotBoy")
        {
            other.gameObject.transform.position = other.gameObject.GetComponent<PlatformerCharacter2D>().m_LastCheckpoint.transform.position;
            foreach(GameObject go in other.gameObject.GetComponent<PlatformerCharacter2D>().usedItems)
            {
                //go.GetComponent<Renderer>().enabled = true;
            }

            resetRegistered();
            other.gameObject.GetComponent<PlatformerCharacter2D>().usedItems.Clear();
        }
        else
        {
            //Destroy(other.gameObject);
            //other.gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
