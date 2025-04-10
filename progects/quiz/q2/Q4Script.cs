using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q4Script : MonoBehaviour
{
    public int i;
    public float f;
    public string s;
    public float fTime;

    // Start is called before the first frame update
    void Start()
    {
        /*字串轉整數*/
        //s = "10";
        //i = int.Parse(s);
        /*字串轉小數*/
        //s = "10.87";
        //f = float.Parse(s);
        /*整數、小數轉字串*/
        //i = 99;
        //s = i.ToString();

        //f = 99.12345f;
        //s = f.ToString();

        /*
        小數轉整數(危險性告知)
        整數轉小數
        */
        //f = 99.12345f;
        //i = (int)f;

        //i = 99;
        //f = i;

        //f = 99.12345f;
        //s = f.ToString("0.00");

        /*隨機範圍Randam.Range-整數*/
        //i = Random.Range(1,101);//1~100

        /*隨機範圍Randam.Range-小數*/
        //f = Random.Range(0, 100);//X

        //i = Random.Range(0, 10000);//O
        //f = i / 100;
    }

    // Update is called once per frame
    void Update()
    {
        /*Time.deltaTime可當計時器用*/
        Debug.Log("fTime:"+ fTime);
        Debug.Log("fTime:" + fTime.ToString("0.00"));
        Debug.Log("Time.deltaTime可當計時器用:" + Time.deltaTime);
        fTime += Time.deltaTime;
        
    }
}
