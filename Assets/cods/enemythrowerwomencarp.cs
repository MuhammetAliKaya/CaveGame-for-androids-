using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemythrowerwomencarp : MonoBehaviour
{
    public GameObject rockpos;
    public float speed;
    public float zamanar = 1.0f;
    public float kalanzmn = 0;
    Vector3 pos;
    Vector3 pos1;
    Vector3 duz;
    Vector3 optm;
    Vector3 optm1;
    public GameObject abcenm;
    RaycastHit2D whatHit;
    RaycastHit2D whatHit2;
    public int health;
    public GameObject friend;
    public GameObject erock;
    public Animator anim;
    RaycastHit2D possafe;
    public bool dolu;
    // Start is called before the first frame update
    void Start()
    {
        health = 7;
        speed = 0.5f;
        pos = new Vector3(-20, 0, 0);
        pos1 = new Vector3(-60, 0, 0);
        optm = new Vector3(-25, 0, 0);
        optm1 = new Vector3(-90, 0, 0);
        duz = new Vector3(-180, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed, 0, 0);
        if (health <= 0)
        {
            gold.gold1 += 80;

            friend.SetActive(false); }

        Debug.DrawLine(pos + transform.position, pos + transform.position + optm, Color.blue);
        possafe = Physics2D.Linecast(pos + transform.position, pos + transform.position + optm);

        if (possafe)
        {
            if ("enm" == possafe.collider.tag)
            {
                //print("dosta çarptı");
                speed = 0;
            }
            else if ("frd" == possafe.collider.tag)
            {
                //print("enm çarptı");
                speed = 0;
                dolu = true;
            }
        }
        else
        {
            speed = 0.5f;
            dolu = false;

        }

        Debug.DrawLine(pos + transform.position + optm, pos + transform.position + optm1, Color.red);
        whatHit = Physics2D.Linecast(pos + transform.position + optm, pos + transform.position + optm1);

        if (whatHit)
        {
            if ("frd" == whatHit.collider.tag)
            {
                print("düşmana çarptı");
                // speed = 0;
                anim.SetBool("hit", true);
            }

        }
        else
        {
            if (!dolu)
            {
                anim.SetBool("hit", false);
                speed = 0.5f;
            }
        }

        Debug.DrawLine(pos + optm1 + transform.position, pos + transform.position + duz, Color.yellow);
        whatHit2 = Physics2D.Linecast(pos + optm1 + transform.position, pos + transform.position + duz);

        if (whatHit2)
        {
            if ("frd" == whatHit2.collider.tag)
            {
                print("düşmana çarptı");
                // speed = 0;
                anim.SetBool("hit", true);
            }

        }
        else
        {
            if (!dolu)
            {
                anim.SetBool("hit", false);
                speed = 0.5f;
            }
        }
    }
    public void yrtrock()
    {
        Instantiate(erock, rockpos.transform.position, rockpos.transform.rotation);

    }
}
