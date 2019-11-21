using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person2Movement : MonoBehaviour
{
    public float Timer;
    public Animator[] Anim;
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
            Anim[0].SetInteger("IsState", 1);
            Anim[1].SetInteger("IsState", 1);
            Anim[2].SetInteger("IsState", 1);


        }
        else if (Timer <= 10)
        {
            Anim[0].SetInteger("IsState", 2);
            Anim[1].SetInteger("IsState", 2);
            Anim[2].SetInteger("IsState", 2);


        }

        else if (Timer <= 15)
        {
            Anim[0].SetInteger("IsState", 3);
            Anim[1].SetInteger("IsState", 3);
            Anim[2].SetInteger("IsState", 3);


        }
        
    }

 
    
}