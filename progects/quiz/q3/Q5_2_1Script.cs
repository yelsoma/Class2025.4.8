using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q5_2_1Script : MonoBehaviour
{
    public Button[] btns;
    public Text[] txts;
    public string[] OXs;

    // Start is called before the first frame update
    void Start()
    {
        btns[0].onClick.AddListener(delegate () {
            OXs[0] = "O";
            txts[0].text = "O";
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
