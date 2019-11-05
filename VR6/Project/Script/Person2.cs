using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person2 : MonoBehaviour
{
    public float Timer;
    public GameObject newboyPos1;
    public GameObject GoUp;

    public Animator []Anim;
     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer<=3)
        {
            Anim[0].SetInteger("IsState", 0);
        }
        else if(Timer<=6)
        {
            Anim[0].SetInteger("IsState", 1);

        }
        else if (Timer <= 7)
        {
            Anim[0].SetInteger("IsState", 2);
            Anim[0].SetBool("IsMoveOnPath", true);
        }

        else if (Timer <= 20 )
        {
            Anim[0].SetInteger("IsState", 3);
            transform.parent = newboyPos1.transform;
        }
        else if (Timer <= 25)
        {
            Anim[1].SetInteger("IsState", 0);
        }
        else if (Timer <= 26)
        {
            Anim[1].SetInteger("IsState", 1);
        }
        else if (Timer <= 27)
        {
            Anim[1].SetInteger("IsState", 2);
        }
        else if (Timer <= 30)
        {
            Anim[1].SetInteger("IsState", 2);
        }

    }
}
