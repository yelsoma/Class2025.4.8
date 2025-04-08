using UnityEngine;
using UnityEngine.UI;

public class BasicUGUIScript : MonoBehaviour
{
    /// <summary>
    /// 文字
    /// </summary>
    public Text txt;
    /// <summary>
    /// 按鈕
    /// </summary>
    public Button btn;
    /// <summary>
    /// 輸入框
    /// </summary>
    public InputField ipt;
    /// <summary>
    /// 圖片(影像)
    /// </summary>
    public Image img;
    /// <summary>
    /// 圖片(精靈)
    /// </summary>
    public Sprite spr;

    void Start()
    {
        txt.text = "哈囉";

        //btn.onClick.AddListener();
        //btn.onClick.AddListener(delegate () { });
        btn.onClick.AddListener(delegate () {
            Debug.Log("btn");
            //txt.text = "btn";
            Debug.Log("ipt:" + ipt.text);
            txt.text = ipt.text;
            img.sprite = null;
        });

        img.sprite = spr;
    }

    void Update()
    {
        
    }
}
