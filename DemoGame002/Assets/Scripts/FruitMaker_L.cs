using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitMaker_L : MonoBehaviour
{
    float zikan2;
    public GameObject[] frt;
    int frtnum;
    // Start is called before the first frame update
    void Start()
    {
        zikan2 = -1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.fixedTime - zikan2 > 2f)
        {
            frtnum = Random.Range(0, 7);
            Instantiate(frt[frtnum], new Vector3(-0.7f, 0f, 5f), Quaternion.identity);
            zikan2 = Time.fixedTime;
        }
    }
}
