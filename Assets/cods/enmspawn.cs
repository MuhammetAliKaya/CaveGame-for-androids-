using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmspawn : MonoBehaviour
{
    public GameObject enemy;
    public static float x2;
    public float timet2;
    public static int es;
    public GameObject spawn;
    public float zamanar = 5000.5f;
    public float kalanzmn = 0;

    // Start is called before the first frame update
    void Start()
    {
        es = 0;
        x2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timet2 = Time.time;
        if (timet2 - x2 > 30.5f)
        {
            timetut();

            Instantiate(enemy, transform.position, transform.rotation);
        }

        if (Time.time >= kalanzmn)
        {
            kalanzmn = zamanar + Time.time;
            Instantiate(spawn, transform.position, transform.rotation);


        }

    }

    public void timetut() {

        x2 = Time.time;
    }
}
