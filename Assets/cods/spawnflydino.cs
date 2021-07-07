using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnflydino : MonoBehaviour
{
    public GameObject flydino;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void yrtflydino()
    {
        if (gold.gold1 >= 150)
        {
            Instantiate(flydino, transform.position, transform.rotation);

            gold.gold1 -= 150;

        }


    }
}
