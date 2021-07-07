using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
    RaycastHit2D whatHit;
    public GameObject rock1;
    Vector3 pos;
    Vector3 optm;

    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        speed = 1.5f;
        pos = new Vector3(5, 0, 0);
        optm = new Vector3(12, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0, 0);

        Debug.DrawLine(optm+transform.position, (optm+transform.position + pos), Color.red);
        whatHit = Physics2D.Raycast(optm+transform.position, transform.right, 5);

        if (whatHit)
        {
            if ("enm" == whatHit.collider.tag)
            {
                speed = 0;

                attack();
                Destroy(rock1);

                //print("değer;" + whatHit.transform.GetComponent<carpenm>().enmhealth);
            }
            

        }
    }
    public void attack() {

        if (whatHit.collider.gameObject.name == "ec1(Clone)")
        {
            whatHit.transform.GetComponent<carpenm>().enmhealth-=3;
        }

        else if (whatHit.collider.gameObject.name == "etw1(Clone)")
        {
            whatHit.transform.GetComponent<enemythrowerwomencarp>().health--;
        }
        else if (whatHit.collider.gameObject.name == "enemycave")
        {
            whatHit.transform.GetComponent<enemycave>().health -= 10; ;
        }




    }

}
