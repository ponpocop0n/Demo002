using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ugoki_ConL : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip koukaon;
    public int point;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.LTouch);
        }

        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.LTouch);
        }

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("fruit"))
        {
            OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.LTouch);
            audio.PlayOneShot(koukaon);
            point += 1;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("fruit"))
        {
            OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.LTouch);
        }
    }
}
