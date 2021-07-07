using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawnflydino : MonoBehaviour
{
    public GameObject enemyflydino;
    public float zamanar = 5.5f;
    public float kalanzmn = 0;

    // Start is called before the first frame update
    void Start()
    {  


}

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= kalanzmn)
        {
            kalanzmn = zamanar + Time.time;
            Instantiate(enemyflydino, transform.position, transform.rotation);
        }

    }
}
