using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class accelerateEffect : MonoBehaviour
{

    public float m_NewMaxSpeed = 15f;
    public float m_EffectTime = 30.0f;
    private PlatformerCharacter2D pc;

    public bool toggleGUI = false;

	private bool activeInWorld = true;

    public AudioSource source;
    public AudioClip bombCollect;

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
            //pc.TriggerAccelEffect(m_NewMaxSpeed, m_EffectTime);
			disappear();

            StartCoroutine("wait");
        }
    }

	void disappear(){
		gameObject.GetComponent<Renderer>().enabled = false;
		activeInWorld = false;
		pc.hasBanana = true;
		GameObject.FindGameObjectWithTag ("BananaSlot").GetComponent<GrayToggle> ().GrayToColor ();
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
            GUI.Box(new Rect(10, 10, 800, 50), "Bananas provide carbohydrate in the form of quick-releasing sugars which your body can use for energy.");
            GUI.skin.box.normal.textColor = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
