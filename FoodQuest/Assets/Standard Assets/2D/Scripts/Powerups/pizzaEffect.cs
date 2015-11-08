using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class pizzaEffect : MonoBehaviour {
    [SerializeField] public float m_newJumpForce = 600f;
    [SerializeField] public float m_EffectTime = 30.0f;

    public bool toggleGUI = false;

	private bool activeInWorld = true;
    public AudioSource source;
    public AudioClip bombCollect;

    private PlatformerCharacter2D pc;
    // Use this for initialization
    void Start () {
	    
	}

    void OnTriggerEnter2D(Collider2D other)
    {
		if ((other.gameObject.name == "CharacterRobotBoy") && (activeInWorld)){
            pc = other.gameObject.GetComponent<PlatformerCharacter2D>();
            other.gameObject.GetComponent<PlatformerCharacter2D>().usedItems.Add(gameObject);
            //pc.PizzaEffect(m_newJumpForce, m_EffectTime);
			disappear();

			//pc.TriggerAccelEffect(0, 3);
            StartCoroutine("wait");
        }
    }

	void disappear(){
		gameObject.GetComponent<Renderer>().enabled = false;
		activeInWorld = false;
		pc.hasPizza = true;
		GameObject.FindGameObjectWithTag ("PizzaSlot").GetComponent<GrayToggle> ().GrayToColor ();
        AudioSource aud = GameObject.FindGameObjectWithTag("PizzaSlot").GetComponent<AudioSource>();
        aud.Play();
    }

    IEnumerator wait()
    {
        toggleGUI = true;
        yield return new WaitForSeconds(3);
        toggleGUI = false;
    }


    void OnGUI()
    {
        if (toggleGUI == true)

            GUI.Box(new Rect(10, 10, 800, 50), "The cheese on pizza is high in saturated fat, which increases your risk for high cholesterol and heart disease.");
            GUI.skin.box.normal.textColor = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

