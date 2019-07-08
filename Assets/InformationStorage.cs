using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationStorage : MonoBehaviour
{
    public static int a = 0;
    public int count_num;

    public Text countTxt;
    // Start is called before the first frame update
    void Start()
    {
        count_num = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (a > count_num){
            count_num = count_num + 1;
        }
        Debug.Log(count_num);
    }

    void SetCountText(){
        countTxt.text = "" + count_num.ToString();
    }

}
