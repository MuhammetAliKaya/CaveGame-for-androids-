using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpenm : MonoBehaviour
{
    public static float konumtut;
    public GameObject abcenm;
    public  float speed;
    public int enmhealth;
    public GameObject enemy;
    public float zamanar = 0.5f;
    public float kalanzmn = 0;
    RaycastHit2D whatHit;
    Vector3 pos;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        enmhealth = 30;
        konumtut = 0;
        speed = 0.5f;
        pos = new Vector3(5, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed, 0, 0);

        if (enmhealth <= 0)
        {
            gold.gold1 += 50;
            enemy.SetActive(false);
        }
        if (speed != 0)
        {
            anim.SetBool("hit", false);
        }







        Debug.DrawLine(transform.position, (transform.position - pos), Color.blue);

        whatHit = Physics2D.Raycast(transform.position, -transform.right, 5);
        if (whatHit)
        {
            if ("frd" == whatHit.collider.tag)
            {
                if (Time.time >= kalanzmn)
                {
                    speed = 0;

                    //print("enm değdi");
                    kalanzmn = zamanar + Time.time;
                    anim.SetBool("hit", true);
                    

                }


                //print("değer;" + whatHit.transform.GetComponent<carp>().health);
            }

            else if ("enm" == whatHit.collider.tag) {

                speed = 0;
            }

        }
        else {
            speed = 0.5f;
        }






        
       
          
        
    }
    /*  void OnTriggerEnter2D(Collider2D abcenm)
      {
          move.yuru = false;
          konumtut = abcenm.transform.position.x;
      }*/
    /*  void OnCollisionEnter2D(Collision2D abcenm)
      {
          print(" ve  arasında çarpışma algılandı.");
          move.yuru = false;
          konumtut = abcenm.transform.position.x;
      }*/



    /* void OnCollisionEnter2D(Collision2D abcenm)
     {
         print(" ve  arasında çarpışma algılandı.");

         konumtut = abcenm.transform.position.x;
         speed = 0;
     }
     void OnCollisionExit2D(Collision2D abcenm)
     {

         speed = 0.5f;

     }*/
    void attack() {
        

        if (whatHit.collider.gameObject.name == "c1(Clone)" ) {
           whatHit.transform.GetComponent<carp>().health-=3;
       }
     
        else if (whatHit.collider.gameObject.name == "tw1(Clone)") {
         whatHit.transform.GetComponent<throwerwomencarp>().health--;
        }
        else if (whatHit.collider.gameObject.name == "cave")
        {
            whatHit.transform.GetComponent<cave>().health-=10;
        }




    }

}
