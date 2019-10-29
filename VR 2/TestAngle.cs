using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAngle : MonoBehaviour
{
    /*
    public Transform[] waypoints;
    public float m_speed;
    public int i=0;

    void Start()
    {
        MoveToWaypoint();
    }
    void OnDrawGizmos()
    {
        iTween.DrawPath(waypoints);
    }

    void MoveToWaypoint()
    {
        iTween.MoveTo(gameObject, iTween.Hash("path", waypoints, "speed", m_speed, "easetype", "linear"));
       
        transform.LookAt(transform.position-transform.forward);
    }

    */


    public Transform[] waypoints;
    public float m_speed = 1.0f;
    public GameObject Airplane;
    public int i = 0;
    private bool moving = false;

    public float Timer = 0.1f;

    public void Start()
    {
        transform.position = waypoints[0].position;


    }

    public void Update()
    {
        Timer -= Time.deltaTime;

        if (!moving && i < waypoints.Length - 1 && Timer <= 0)
        {
            i++;
            moving = true;

            iTween.MoveTo(Airplane, iTween.Hash("position", waypoints[i], "speed", m_speed, "easetype", "linear", "oncompletetarget", gameObject, "oncomplete", "Done"));
            Timer = 0.1f;
        }

        if (transform.position == waypoints[2].position)
        {
            // transform.LookAt(transform.position - transform.forward);
            //  transform.Rotate(0, 180, 0);

            // var dir = -(waypoints[2].position - transform.position);
            // var angle = Mathf.Atan2(dir.y, dir.x);
            // transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            // transform.LookAt(transform.position - transform.forward);
            // transform.Rotate(0, degree, 0);


            //  var rotation = transform.rotation;
            // transform.RotateAround(transform.position, Vector3.forward, 0.5f * Time.deltaTime);
            //
            // transform.rotation = rotation;
            transform.LookAt(transform.position - transform.forward);
            transform.Rotate(0, 180, 0);


        }

        if (i == 14)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1f * Time.deltaTime);
        }

    }

    public void Done()
    {
        moving = false;
    }


}