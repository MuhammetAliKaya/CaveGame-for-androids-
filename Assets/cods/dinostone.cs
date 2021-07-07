using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinostone : MonoBehaviour
{
    RaycastHit2D whatHit;
    public GameObject rock1;
    Vector3 pos;
    Vector3 pos1;
    public float speed;
    public float speedy;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.4f;
        speedy = -1.0f;

        pos = new Vector3(3, 15, 0);
        pos1 = new Vector3(-28, 15, 0);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, speedy, 0);

        Debug.DrawLine(pos + transform.position, pos1 + transform.position, Color.red);
        whatHit = Physics2D.Linecast(pos + transform.position, pos1 + transform.position);

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
    public void attack()
    {

        if (whatHit.collider.gameObject.name == "ec1(Clone)")
        {
            whatHit.transform.GetComponent<carpenm>().enmhealth -= 30;
        }

        else if (whatHit.collider.gameObject.name == "etw1(Clone)")
        {
            whatHit.transform.GetComponent<enemythrowerwomencarp>().health -= 30;
        }
        else if (whatHit.collider.gameObject.name == "enemycave")
        {
            whatHit.transform.GetComponent<enemycave>().health -= 30; ;
        }
    }
}