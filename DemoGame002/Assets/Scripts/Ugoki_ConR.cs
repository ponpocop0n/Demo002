using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ugoki_ConR : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip koukaon_1;
    public AudioClip koukaon_2;
    public Text text;
    public Text scoreText;
    public static int score;
    public int s;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        /*
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.RTouch);
        }
      
        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.RTouch);
        }
        */
        text.text = "右コントローラ角度" + gameObject.transform.localEulerAngles.y.ToString();
        scoreText.text = "スコア" + score.ToString();
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("fruit"))
        {
            OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.RTouch);
            audio.PlayOneShot(koukaon_1);
            score += 2;
        }
        if (col.CompareTag("bomb"))
        {
            OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.RTouch);
            audio.PlayOneShot(koukaon_2);
            score -= 1;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("fruit"))
        {
            OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.RTouch);
        }
    }
    public static int getScore()
    {
        return score;
    }
    
}
