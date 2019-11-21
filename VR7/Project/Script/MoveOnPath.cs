using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnPath : MonoBehaviour
{

    public Transform[] targets;
    public float Speed;
    public int Current;
    public bool IsMovePlayer = true;
    public Animator []Anim;
    public GameObject NewPos;


    public void Start()
    {
        Anim[0].SetInteger("IsState", 1);

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


                if (Current == targets.Length-1)
                {
                    IsMovePlayer = false;
                    Anim[0].SetInteger("IsState", 2);
                    transform.Rotate(0f, 180f, 0f);
                    transform.parent = NewPos.transform;
                }
            }
        }

       
        }


    }        
 