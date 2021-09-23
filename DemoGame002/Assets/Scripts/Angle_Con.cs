using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Angle_Con : MonoBehaviour
{

    public Transform front_L, front_R, back_L, back_R;
    Vector3 hiraki_v1, hiraki_v2;
    public static float hiraki;
    public Text hiraki_T;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        hiraki_v1 = front_L.position - back_L.position;//左コントローラの方向ベクトル
        hiraki_v2 = front_R.position - back_R.position;//右コントローラの方向ベクトル
        if(hiraki_v1 != null && hiraki_v2 != null)
        {
            hiraki = Vector3.Angle(hiraki_v1, hiraki_v2);//上記二つのベクトルの角度
            hiraki_T.text = "開き度合い：" + hiraki.ToString();
        }
        else
        {
            hiraki_T.text = "正常に読み取れません。";
        }
       
    }
    public static float getHiraki()
    {
        return hiraki;
    }
}
