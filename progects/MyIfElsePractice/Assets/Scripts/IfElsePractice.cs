using UnityEngine;

public class IfElsePractice : MonoBehaviour
{
    [SerializeField] private int i1;
    [SerializeField] private float f1;
    [SerializeField] private bool b1;
    [SerializeField] private string s1;
    private void Start()
    {
        if(b1 == true)
        {
            Debug.Log("b1" + "=" + "true");
        }
        else if (b1 == false)
        {
            Debug.Log("b1" + "=" + "false");
        }
        else
        {
            Debug.Log("this is not posible");
        }

        if (i1 > 0)
        {
            Debug.Log("i1" + ">0");
        }
        else if (i1 == 0)
        {
            Debug.Log("i1" + "=0");
        }
        else
        {
            Debug.Log("i1" + "<0");
        }

        if (f1 > 0)
        {
            Debug.Log("f1" + ">0" );
        }
        else if(f1 ==0)
        {
            Debug.Log("f1" + "=0");
        }
        else
        {
            Debug.Log("f1" + "<0");
        }
        
        if(s1 == "«¢«¢")
        {
            Debug.Log("¯º§¾");
        }

        if(s1 != "«¢«¢") Debug.Log("½Ð¿é¤J«¢«¢");
    }
}
