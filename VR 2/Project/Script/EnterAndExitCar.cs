using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterAndExitCar : MonoBehaviour
{

    public Animator Anim;
    public Animator Anim2;

    bool IsMovePlayer = true;


    public GameObject ParentObj;
    public GameObject ChildObj;

    public static bool IsMoveCar = false;
    //  public Transform PersonExitPos;
    bool IsRotate = true;
    bool IsExit = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    



    public void OnTriggerEnter(Collider other)
    {



        if (other.tag == "EnterToCarTag")
        {
            Anim.SetBool("IsEnter", true);
            Anim2.SetBool("IsCarDoorOpen", true);
            //Makes the GameObject "ParentObj" the parent of the GameObject "ChildObj".
            ChildObj.transform.parent = ParentObj.transform;
            StartCoroutine(ISMoveCarOnpath());
            print("Enter Car");

        }

        if (other.tag == "ExitToCarTag")
        {
            ChildObj.transform.parent = null;
            transform.position = new Vector3(-1.76f, -0.895f, 5.194f);
            if (IsRotate)
            {
                transform.Rotate(0, -100, 0);
                IsRotate = false;
            }

            Anim.SetBool("IsEnter", false);
            Anim2.SetBool("IsCarDoorOpen", true);


            if (IsExit == true)
            {
                Anim.SetBool("IsExit", true);
                IsExit = false;
            }

            print("Exit Car");
        }



        if (IsExit == false)
        {
            Anim.SetBool("IsExit", false);

        }
    }

    IEnumerator ISMoveCarOnpath()
    {
        yield return new WaitForSeconds(10f);
        IsMoveCar = true;

    }



    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "EnterToCarTag")
        {
            Anim2.SetBool("IsCarDoorOpen", false);
        }

        
        

    }


   
}
