using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitMaker_R : MonoBehaviour
{
    float zikan;
    public GameObject[] frt;
    int frtnum;
    int flg;
    // Start is called before the first frame update
    void Start()
    {
        flg = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.fixedTime - zikan > 1f)
        {
            if (flg % 2 == 0)
            {
                frtnum = 7;
            }

            if (flg % 2 == 1)
            {  
                frtnum = Random.Range(0, 7);
            }
            Instantiate(frt[frtnum], new Vector3(-0.3f, 0f, 50f), Quaternion.identity);
            zikan = Time.fixedTime;
            flg += 1;
        }
    }
}
