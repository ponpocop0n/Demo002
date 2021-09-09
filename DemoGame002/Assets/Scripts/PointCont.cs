using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCont : MonoBehaviour
{
    public int point;
    public AudioSource audio;
    public AudioClip sound;
    // Start is called before the first frame update
    void Start()
    {
        point = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (point > 20)
        {
            audio.PlayOneShot(sound);
        }
    }
}
