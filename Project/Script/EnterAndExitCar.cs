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
            Anim.SetBool("IsExit", true);
            Anim.SetBool("IsEnter", false);
                print("Exit Car");
            }

    }

    IEnumerator ISMoveCarOnpath()
    {
        yield return new WaitForSeconds (10f);
        IsMoveCar = true;

    }
}
