using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
public class spawnsword : MonoBehaviour
{
    public float timet;
    public GameObject adam;
    public static float a;
    public bool flag;
    public  float x;
    // Start is called before the first frame update
    void Start()
    {
        a = 0;
        
    }

    //Update is called once per frame
    void Update()
    {
        
            timet = Time.time;
        
       // UnityEngine.Debug.Log(timet.ToString());
        //UnityEngine.Debug.Log(a.ToString());
 
    }
    public void yrt()
    {


        if (timet-x > 0)
        {
            x = Time.time;
            if (gold.gold1 >= 50)
            {
                Instantiate(adam, transform.position, transform.rotation);
                gold.gold1 -= 50;
               
            }
            

        }
    }

}
