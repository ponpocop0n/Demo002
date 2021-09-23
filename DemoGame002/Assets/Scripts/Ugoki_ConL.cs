using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ugoki_ConL : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip koukaon_1;
    public AudioClip koukaon_2;
    public Text scoreText;
    public static int score;
    int score_L;
    public AudioClip sound;

    public object GetFruit { get; private set; }

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        /*
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.LTouch);
        }

        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.LTouch);
        }
        */

        //text.text = "左コントローラ角度" + gameObject.transform.localEulerAngles.y.ToString();

        score = Ugoki_ConR.getScore() + score_L;
        scoreText.text = "スコア" + score.ToString();
        if (score > 10)
        {
            audio.PlayOneShot(sound);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("fruit"))
        {
            OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.LTouch);
            audio.PlayOneShot(koukaon_1);
            score_L += 2;
             
        }
        if (col.CompareTag("bomb"))
        {
            OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.LTouch);
            audio.PlayOneShot(koukaon_2);
            score_L -= 1;
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
