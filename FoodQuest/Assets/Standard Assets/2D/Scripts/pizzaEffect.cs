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
            pc.PizzaEffect(m_newJumpForce, m_EffectTime);
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}
