using UnityEngine;
using System.Collections;

public class FallAfterTime : MonoBehaviour
{
    [SerializeField]
    public float m_EffectTime = 3.0f;

    // Use this for initialization
    void Start()
    {

    }
    private bool falling = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!falling)
        {
            if (other.gameObject.name == "CharacterRobotBoy")
            {
                falling = true;
                Invoke("FallEffect", m_EffectTime);
            }
        }
    }

    void FallEffect()
    {
        Rigidbody2D rigidBody = gameObject.GetComponentInParent<Rigidbody2D>();
        rigidBody.gravityScale = 3.0f;
        rigidBody.isKinematic = false;
    }


}
