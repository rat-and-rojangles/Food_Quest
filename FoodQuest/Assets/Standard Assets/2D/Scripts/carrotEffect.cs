using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class carrotEffect : MonoBehaviour
{
    [SerializeField]
    public float m_newScale = 600f;
    [SerializeField]
    public float m_EffectTime = 20.0f;

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
            pc.CarrotEffect(m_newScale, m_EffectTime);
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}
