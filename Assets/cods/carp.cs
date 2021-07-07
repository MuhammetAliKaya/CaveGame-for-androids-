using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carp : MonoBehaviour
{
    public static float konumtut;
    public  GameObject abc;
    public  float speed;
    public float zamanar=0.5f;
    public float kalanzmn=0;
    public Animator anim;
    public int health;
    Vector3 pos;
    RaycastHit2D whatHit;
    public GameObject friend;
    // Start is called before the first frame update
    void Start()
    {
        health = 30;
        konumtut = 0;
        speed = 0.5f;
        pos = new Vector3 (5,0,0);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0, 0);

        if (health <= 0)
        {

            friend.SetActive(false);
        }
        if (speed != 0)
        {
            anim.SetBool("hit", false);
        }



        

        Debug.DrawLine(transform.position,(transform.position + pos),Color.green);

        /* whatHit= Physics2D.Linecast(transform.position, (transform.position + pos),1<<LayerMask.NameToLayer("enm") );
              print(" lineeeee");*/

      

        whatHit = Physics2D.Raycast(transform.position, transform.right, 5);
        if (whatHit)
        {
            if ("enm" == whatHit.collider.tag)
            {
                if (Time.time >= kalanzmn)
                {
                    speed = 0;

                    //print("enm değdi");
                    
                    kalanzmn = zamanar + Time.time;
                    anim.SetBool("hit", true);
                }


               // print("değer;" + whatHit.transform.GetComponent<carpenm>().enmhealth);
            }
            else if ("frd" == whatHit.collider.tag) {

                speed = 0;
            
            }

        }
        else {

            speed = 0.5f;
        }





    }

    /* void OnTriggerEnter2D(Collider2D abc)
     {

     }*/
  /*  void OnCollisionEnter2D(Collision2D abc)
    {
      
    }*/
    void attack() {
       
        if (whatHit.collider.gameObject.name == "ec1(Clone)")
        {
            whatHit.transform.GetComponent<carpenm>().enmhealth -= 3;
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

      /*  void OnCollisionStay2D(Collision2D abc)
    {
        print(" ve  arasında çarpışma algılandı.");
        
        konumtut = abc.transform.position.x;
        speed = 0;
    }
    void OnCollisionExit2D(Collision2D abc)
    {
        transform.Translate(2.5f, 0, 0);


        speed = 0.5f;
        

    }*/
}
