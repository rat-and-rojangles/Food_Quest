using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class carrotEffect : MonoBehaviour
{
    [SerializeField]
    public float m_newScale = 600f;
    [SerializeField]
    public float m_EffectTime = 20.0f;

	public bool toggleGUI = false;

	private bool activeInWorld = true;

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
            pc.CarrotEffect(m_newScale, m_EffectTime);
			disappear();

			StartCoroutine("wait");
        }
    }

	IEnumerator wait()
	{
		toggleGUI = true;
		yield return new WaitForSeconds(3);
		toggleGUI = false;
	}

	void disappear(){
		gameObject.GetComponent<Renderer>().enabled = false;
		activeInWorld = false;
		pc.hasCarrot = true;
		GameObject.FindGameObjectWithTag ("CarrotSlot").GetComponent<GrayToggle> ().GrayToColor ();
	}

	void OnGUI()
	{
		if (toggleGUI == true)
			GUI.Box(new Rect(10, 300, 800, 50), "Carrots are very high in vitamin A, an essential nutrient for good vision.");
		GUI.skin.box.normal.textColor = Color.white;
	}
}
