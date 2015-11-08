using UnityEngine;
using System.Collections;

//This script will attach to anthing that has a collision

public class CamShakeSimple : MonoBehaviour
{


    float shakeAmt = 0;

    public float shakeFactor = .0025f;
    public Camera mainCamera;

    public AudioClip slamSound;

    private float normalShakeAmt = 0.1f;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ground")
        {
            AudioSource.PlayClipAtPoint(slamSound, transform.position, shakeAmt / normalShakeAmt); 

            /*AudioSource audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.Play();
            audioSource.volume = shakeAmt / normalShakeAmt;*/

            //The shake amount is based on collsion velocity.
            shakeAmt = coll.relativeVelocity.magnitude * shakeFactor;
            InvokeRepeating("CameraShake", 0, .01f);
            Invoke("StopShaking", 0.3f);
        }

    }

    void CameraShake()
    {
        /*if (shakeAmt > 0)
        {
            float quakeAmt = Random.value * shakeAmt * 2 - shakeAmt;
            Vector3 pp = mainCamera.transform.position;
            pp.y += quakeAmt; // can also add to x and/or z
            mainCamera.transform.position = pp;
        }*/
        if (shakeAmt > 0)
        {
            float quakeX = Random.value * shakeAmt * 2 - shakeAmt;
            float quakeY = Random.value * shakeAmt * 2 - shakeAmt;
            Vector3 pp = mainCamera.transform.position;
            //Vector3 pp = mainCamera.GetComponent<CameraFollow>().targetLocation;
            pp.x += quakeX;
            pp.y += quakeY;
            mainCamera.transform.position = pp;

        }
    }

    void StopShaking()
    {
        CancelInvoke("CameraShake");
    }

}