using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class steakEffect : MonoBehaviour
{
    [SerializeField]
    public float m_EffectTime = 15.0f;

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
            // put in inventory
            TriggerEffect();
            Destroy(gameObject);
        }
    }

    void TriggerEffect()
    {
        // should save these and reuse it rather then recalculating each time. But this is a hackathon.
        foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("heavyCrate"))
        {
            fooObj.GetComponent<Rigidbody2D>().isKinematic = false;
        }
        Invoke("EndEffect", m_EffectTime);
    }

    void EndEffect()
    {
        foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("heavyCrate"))
        {
            //TODO: They will stop moving even if in mid-fall... fix later.
            fooObj.GetComponent<Rigidbody2D>().isKinematic = true;
        }
    }
}
