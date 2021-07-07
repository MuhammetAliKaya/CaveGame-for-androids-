using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cave : MonoBehaviour
{
    public int health;
    public Text showcavehealth;
    public Slider hs;
    // Start is called before the first frame update
    void Start()
    {
        health = 1000;
        showcavehealth.text = "" + health;
        hs.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        showcavehealth.text = "" + health;
        hs.value = health;


    }
}
