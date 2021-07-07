using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class erock : MonoBehaviour
{
    RaycastHit2D whatHit;
    public GameObject rock1;
    Vector3 pos;
    Vector3 optm;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = -1.5f;
        pos = new Vector3(-5, 0, 0);
        optm = new Vector3(-12, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0, 0);

        Debug.DrawLine(optm + transform.position, (optm + transform.position + pos), Color.red);
        whatHit = Physics2D.Raycast(optm + transform.position, transform.right, 5);

        if (whatHit)
        {
            if ("frd" == whatHit.collider.tag)
            {
                speed = 0;

                attack();
                Destroy(rock1);

                //print("değer;" + whatHit.transform.GetComponent<carpenm>().enmhealth);
            }


        }
       

    }
    public void attack()
    {

        if (whatHit.collider.gameObject.name == "c1(Clone)")
        {
            whatHit.transform.GetComponent<carp>().health -= 3;
        }

        else if (whatHit.collider.gameObject.name == "tw1(Clone)")
        {
            whatHit.transform.GetComponent<throwerwomencarp>().health--;
        }
        else if (whatHit.collider.gameObject.name == "cave")
        {
            whatHit.transform.GetComponent<cave>().health -= 10;
        }




    }
}
