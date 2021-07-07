using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cammoce : MonoBehaviour
{ public float a1;
  public float a2;
  public float a1t;
  public float a2t;

    // Start is called before the first frame update
    void Start()
    {
        a1 = 0;
        a2 = 0;
        a1t = 1;
        a2t = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (a1t == a1)
        {
            
            transform.Translate(50f, 0, 0);
            transform.Translate(50f, 0, 0);
            transform.Translate(50f, 0, 0);
            transform.Translate(50f, 0, 0);
            a1t++;
        }
        if (a2t == a2) {
            
            transform.Translate(-200, 0, 0);
            a2t++;
        }
    }
    public void movecontsağ() {
        a1++;
        UnityEngine.Debug.Log(a1.ToString());

    }
    public void movecontsol()
    {
        a2++;


    }
}
