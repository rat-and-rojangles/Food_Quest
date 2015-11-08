using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class pizzaEffect : MonoBehaviour {
    [SerializeField] public float m_newJumpForce = 600f;
    [SerializeField] public float m_EffectTime = 30.0f;

    private PlatformerCharacter2D pc;
    // Use this for initialization
    void Start () {
	    
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "CharacterRobotBoy") {
            pc = other.gameObject.GetComponent<PlatformerCharacter2D>();
            other.gameObject.GetComponent<PlatformerCharacter2D>().usedItems.Add(gameObject);
            // put in inventory
            TriggerEffect();
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }

    void TriggerEffect()
    {
        pc.m_JumpForce = m_newJumpForce;
        Invoke("EndEffect", m_EffectTime);
    }

    void EndEffect()
    {
        pc.m_JumpForce = pc.defaultJumpForce;
    }

	// Update is called once per frame
	void Update () {
	
	}
}
