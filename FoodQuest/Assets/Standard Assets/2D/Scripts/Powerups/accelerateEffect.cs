using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class accelerateEffect : MonoBehaviour
{

    public float m_NewMaxSpeed = 15f;
    public float m_EffectTime = 30.0f;
    private PlatformerCharacter2D pc;

    public bool toggleGUI = false;

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
            pc.TriggerAccelEffect(m_NewMaxSpeed, m_EffectTime);
            gameObject.GetComponent<Renderer>().enabled = false;

            StartCoroutine("wait");
        }
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
            GUI.Box(new Rect(10, 300, 800, 50), "Bananas provide carbohydrate in the form of quick-releasing sugars which your body can use for energy.");
            GUI.skin.box.normal.textColor = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
