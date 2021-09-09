using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ugoki_ConR : MonoBehaviour
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
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.RTouch);
        }
      
        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.RTouch);
        }

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("fruit"))
        {
            OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.RTouch);
            audio.PlayOneShot(koukaon);
            point = point+1;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("fruit"))
        {
            OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.RTouch);
        }
    }
}
