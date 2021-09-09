using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitMaker_R : MonoBehaviour
{
    float zikan1;
    public GameObject[] frt;
    int frtnum;
    // Start is called before the first frame update
    void Start()
    {
        zikan1 = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.fixedTime - zikan1 > 2f)
        {
            frtnum = Random.Range(0, 7);
            Instantiate(frt[frtnum], new Vector3(0.5f, 0f, 5f), Quaternion.identity);
            zikan1 = Time.fixedTime;
        }
    }
}