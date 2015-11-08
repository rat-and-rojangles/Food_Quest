using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class steakEffect : MonoBehaviour, IPowerup
{
    [SerializeField]
    public float m_EffectTime = 15.0f;
	private bool activeInWorld = true;

    private PlatformerCharacter2D pc;
    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "CharacterRobotBoy")
        {
            pc = other.gameObject.GetComponent<PlatformerCharacter2D>();
            other.gameObject.GetComponent<PlatformerCharacter2D>().usedItems.Add(gameObject);
			applyPower();
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }

	void applyPower(){
		pc.SteakEffect(m_EffectTime);
	}

	void addToInventory();
	void removeFromInventory();

	void disappear(){
		gameObject.GetComponent<Renderer>().enabled = false;
		activeInWorld = false;
	}
	void respawn(){
		gameObject.GetComponent<Renderer>().enabled = true;
		activeInWorld = true;
	}

	bool inWorld(){
		return activeInWorld;
	}
}