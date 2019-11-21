using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person1Movement : MonoBehaviour
{
    public float Timer;
    public Animator Anim;
    public Animator Anim2;
    public Animator Anim3;
    public Animator Anim4;
    public Animator Anim5;

    public GameObject BoyOrignalPos;
    public GameObject BoySecondPos;
    public GameObject Boy3Pos;



    //.................




    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        Timer += Time.deltaTime;

        if (Timer <= 3)
        {
            //sit
            Anim.SetInteger("IsState", 1);
        }
        else if (Timer <= 6)
        {
            //stand
            Anim.SetInteger("IsState", 2);
        }
        else if (Timer <= 10)
        {
            //walk
            Anim.SetInteger("IsState", 3);
            //move on path 1
            Anim2.SetInteger("IsMoveOnPath", 1);
        }
        else if (Timer <= 15)
        {
            //move on path 1
            Anim2.SetInteger("IsMoveOnPath", 0);
            //sit
            Anim.SetInteger("IsState", 4);
            transform.parent = BoySecondPos.transform;
        }

        else if (Timer <= 20)
        {
            //Up
            Anim3.SetInteger("IsState", 1);
        }
        else if (Timer <= 25)
        {
            //Rotate
            Anim3.SetInteger("IsState", 2);
        }
        else if (Timer <= 30)
        {
            // down
            Anim3.SetInteger("IsState", 3);
        }
        else if (Timer <= 33)
        {
            //stand
            Anim.SetInteger("IsState", 5);

        }
        else if (Timer <= 35)
        {

            //walk
            Anim.SetInteger("IsState", 3);
            //move on path 1
            Anim4.SetInteger("IsMoveOnPath", 1);

        }

        else if (Timer <= 36)
        {
            //sit
            Anim.SetInteger("IsState", 4);
        }
        else if (Timer <= 40)
        {
            transform.parent = Boy3Pos.transform;
        }
        else if (Timer <= 60)
        {
            //stand
            Anim.SetInteger("IsState", 6);
            //move on path 1
            Anim5.SetInteger("IsMoveOnPath", 1);
        }
        else if (Timer <= 61)
        {
            //stand
            Anim.SetInteger("IsState", 7);

        }

        }
}