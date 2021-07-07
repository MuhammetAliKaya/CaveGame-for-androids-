using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemycave : MonoBehaviour

{
    public int health;
    public Text showcavehealth;
    public Slider hs;
    public void sahnedon() {
        SceneManager.LoadScene(0);
    }

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
        if(health<=0){
        sahnedon();

            
        }
        
    }
}
