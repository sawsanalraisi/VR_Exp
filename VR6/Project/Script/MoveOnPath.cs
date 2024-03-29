﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnPath : MonoBehaviour
{
    public Transform[] targets;
    public float Speed;
    public int Current;
    public bool IsMovePlayer=true;
     public Animator Anim;
  //  public int WayPointStop;


    // Start is called before the first frame update
    void Start()
    {
        Anim.SetBool("IsMove", true);

    }

    // Update is called once per frame
    void Update()
    {
        if (IsMovePlayer == true)
        {
            if (transform.position != targets[Current].position)
            {
                Vector3 pos = Vector3.MoveTowards(transform.position, targets[Current].position, Speed * Time.deltaTime);
                GetComponent<Rigidbody>().MovePosition(pos);
                transform.LookAt(targets[Current]);                
            }
            else
            {
                Current = (Current + 1) % targets.Length;
                if (Current == 4)
                {
                    IsMovePlayer = false;
                   Anim.SetBool("IsMove", false);
                }
            }
        }

        print(targets[Current]);
          //  IsMove = false;

       



    }
}
