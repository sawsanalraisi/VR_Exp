using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAngle : MonoBehaviour
{


    public Transform[] targets;
    public float Speed;
    public int Current;
    public bool IsMovePlayer = true;


    public int WayPointStop;


    EnterAndExitCar EnterAndExitCar;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsMovePlayer == true && EnterAndExitCar.IsMoveCar == true)
        {
            MoveWayPointsFunction();
        }

    }



    /*
    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "AirplaneTag")
        {
            MoveWayPointsFunction();
        } 
    
    }

            
    */

    void MoveWayPointsFunction()
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

            if (Current == WayPointStop)
            {
                IsMovePlayer = false;
                //DataManger.Instance.IsMoveCar = false;
            }
        }
    }




}