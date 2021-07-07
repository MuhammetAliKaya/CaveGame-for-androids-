using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class gold : MonoBehaviour
{
    public Text showgold;
    public static int gold1;
    //public Text m_MyText;
    // Start is called before the first frame update
    void Start()
    {
        showgold.text = "try";
        gold1 = 500;
    }

    // Update is called once per frame
    void Update()
    {
        showgold.text = "" + gold1;
        //gold1++;

    }


}
