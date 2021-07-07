using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnthrovwomen : MonoBehaviour
{
    public GameObject spawn
        ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void yrtthrow()
    {
        if (gold.gold1 >= 80)
        {
            Instantiate(spawn, transform.position, transform.rotation);

            gold.gold1 -= 80;

        }

    }
}
