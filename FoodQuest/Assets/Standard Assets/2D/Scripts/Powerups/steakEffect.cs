using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class steakEffect : MonoBehaviour//, IPowerup
{
    [SerializeField]
    public float m_EffectTime = 15.0f;
	private bool activeInWorld = true;

    public bool toggleGUI = false;

    private PlatformerCharacter2D pc;
    // Use this for initialization
    void Start()
    {
		
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.name == "CharacterRobotBoy") && (activeInWorld))
        {
            pc = other.gameObject.GetComponent<PlatformerCharacter2D>();
            other.gameObject.GetComponent<PlatformerCharacter2D>().usedItems.Add(gameObject);
			applyPower();
            gameObject.GetComponent<Renderer>().enabled = false;
			disappear();

            StartCoroutine("wait");
        }
    }
//<<<<<<< HEAD:FoodQuest/Assets/Standard Assets/2D/Scripts/Powerups/steakEffect.cs

	void applyPower(){
		pc.SteakEffect(m_EffectTime);
	}

	//void addToInventory();
	//void removeFromInventory();

	void disappear(){
		gameObject.GetComponent<Renderer>().enabled = false;
		activeInWorld = false;
		pc.hasSteak = true;
	}
	void respawn(){
		gameObject.GetComponent<Renderer>().enabled = true;
		activeInWorld = true;
		pc.hasSteak = false;
	}

	bool inWorld(){
		return activeInWorld;
	}

//=======
    IEnumerator wait()
    {
        toggleGUI = true;
        yield return new WaitForSeconds(3);
        toggleGUI = false;
    }

    void OnGUI()
    {
		if (toggleGUI == true)

            GUI.Box(new Rect(10, 300, 800, 50), "Red meat provides protein, which helps build bones and muscle strength.");
            GUI.skin.box.normal.textColor = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
//>>>>>>> origin/master:FoodQuest/Assets/Standard Assets/2D/Scripts/steakEffect.cs
