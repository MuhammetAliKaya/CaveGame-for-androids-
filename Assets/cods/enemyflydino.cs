using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyflydino : MonoBehaviour
{
    public int health;
    public float speed;
    Vector3 pos;
    Vector3 pos1;
    Vector3 pos2;
    Vector3 pos3;
    public GameObject friend;
    public GameObject stonepos;
    public GameObject dinostone;
    RaycastHit2D whatHit;
    RaycastHit2D whatHit2;
    public Animator anim;
    public bool speedcheck;
    public bool speedcheck1;
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
        speed = -0.5f;
        pos = new Vector3(-20, -20, 0);
        pos1 = new Vector3(-20, -100, 0);
        pos2 = new Vector3(-70, 5, 0);
        pos3 = new Vector3(-80, 5, 0);
        speedcheck = false;
        speedcheck1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0, 0);
        if (health <= 0)
        {
            friend.SetActive(false);
            gold.gold1 += 150;
        }
        Debug.DrawLine(pos2 + transform.position, pos3 + transform.position, Color.blue);
        whatHit = Physics2D.Linecast(pos2 + transform.position, pos3 + transform.position);

        if (whatHit)
        {
            if ("frd" == whatHit.collider.tag)
            {
                print("flyyyyyyyyyyy");
                speed = 0;
                anim.SetBool("hit1", true);
                speedcheck = false;

            }

            if ("enm" == whatHit.collider.tag)
            {
                print("düşmana çarptı");
                speed = 0;
                speedcheck = false;

            }
        }
        else
        {
            speedcheck = true;

            anim.SetBool("hit1", false);

        }



        Debug.DrawLine(pos + transform.position, pos1 + transform.position, Color.red);
        whatHit2 = Physics2D.Linecast(pos + transform.position, pos1 + transform.position);

        if (whatHit2)
        {
            if ("frd" == whatHit2.collider.tag)
            {
                print("düşmana çarptı");
                speed = 0;
                anim.SetBool("hit", true);
                speedcheck1 = false;


            }


        }
        else
        {

            anim.SetBool("hit", false);
            speedcheck1 = true;



        }
        if (speedcheck)
        {
            if (speedcheck1)
            {
                speed = -0.5f;

            }
        }

    }
    public void yrtstone()
    {
        Instantiate(dinostone, stonepos.transform.position, stonepos.transform.rotation);

    }
    public void attack()
    {
       
                if (whatHit.collider.gameObject.name == "ec1(Clone)")
                {
                    whatHit.transform.GetComponent<carpenm>().enmhealth -= 3;
                }

                else if (whatHit.collider.gameObject.name == "etw1(Clone)")
                {
                    whatHit.transform.GetComponent<enemythrowerwomencarp>().health--;
                }
                else if (whatHit.collider.gameObject.name == "fd1(Clone)")
                {
                       whatHit.transform.GetComponent<flydino>().health -= 15;
                 }
    }
}
