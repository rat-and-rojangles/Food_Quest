using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class avocadoEffect : MonoBehaviour
{
    [SerializeField]
    public float m_newJumpForce = 600f;
    [SerializeField]
    public float m_EffectTime = 30.0f;

    public bool toggleGUI = false;

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
            pc.PizzaEffect(m_newJumpForce, m_EffectTime);
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

            GUI.Box(new Rect(10, 300, 800, 50), "Avocado is loaded with heart-healthy monounsaturated fatty acids.");
        GUI.skin.box.normal.textColor = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

