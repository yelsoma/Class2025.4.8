using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q3_2_1 : MonoBehaviour
{
    /*
     - 題目1 :
    在Update裡寫上"一次" Debug.Log(index); 印出 0~10

    例如 :
    0
    1
    2
    3
    4
    5
    6
    7
    8
    9
    10
    */
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(index<=10)
            Debug.Log(index);
        index++;
    }
}
