using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class accelerateEffect : MonoBehaviour {

    public float m_NewMaxSpeed = 15f;
    public float m_EffectTime = 30.0f;
    private PlatformerCharacter2D pc;
    // Use this for initialization
    void Start () {
	
	}
	
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "CharacterRobotBoy")
        {
            pc = other.gameObject.GetComponent<PlatformerCharacter2D>();
            pc.TriggerAccelEffect(m_NewMaxSpeed, m_EffectTime);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
