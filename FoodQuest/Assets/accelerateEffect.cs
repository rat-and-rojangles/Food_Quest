using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class accelerateEffect : MonoBehaviour {

    public float m_NewMaxSpeed = 15f;
	// Use this for initialization
	void Start () {
	
	}
	
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "CharacterRobotBoy")
        {
            other.gameObject.GetComponent<PlatformerCharacter2D>().m_MaxSpeed = m_NewMaxSpeed;
            Destroy(gameObject);
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
