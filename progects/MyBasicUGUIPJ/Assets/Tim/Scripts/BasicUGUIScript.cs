using UnityEngine;
using UnityEngine.UI;

public class BasicUGUIScript : MonoBehaviour
{
    /// <summary>
    /// ��r
    /// </summary>
    public Text txt;
    /// <summary>
    /// ���s
    /// </summary>
    public Button btn;
    /// <summary>
    /// ��J��
    /// </summary>
    public InputField ipt;
    /// <summary>
    /// �Ϥ�(�v��)
    /// </summary>
    public Image img;
    /// <summary>
    /// �Ϥ�(���F)
    /// </summary>
    public Sprite spr;

    void Start()
    {
        txt.text = "���o";

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
