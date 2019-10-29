using System.Collections;
using UnityEngine;

public class Airplane : MonoBehaviour
{

    public float Timer = 5f;
    public Transform Traget;

    // public Transform Target;
    void Update()
    {

        Timer -= Time.deltaTime;


        if (Timer <= 0)
        {
            //transform.position -= transform.forward * Time.deltaTime * 0.1f;
          //  transform.position -= new Vector3(transform.position.x, transform.position.y+ Time.deltaTime * 0.1f, transform.position.z);


             
              
           
              

            //float degrees = 90;
            // Vector3 to = new Vector3(degrees, 0, 0);
            // transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, to, Time.deltaTime);
            //..........................................

            // transform.position -= transform.forward * Time.deltaTime * 0.1f;



            //transform.rotation = Quaternion.Euler(-90,0,0f);

            //....................

            // transform.eulerAngles = new Vector3(-90, 0, 0);
            //transform.localEulerAngles = new Vector3(degrees, transform.localEulerAngles.y, transform.localEulerAngles.z);
            //transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * 10.0f, Space.World);
            // transform.Rotate(new Vector3(0, 0, 0) * Time.deltaTime * 0.01f, Space.World);

            //............
            //transform.transform.rotation = Quaternion.Slerp(transform.transform.rotation, Quaternion.Euler(-degrees, 0, 0), 0.01f * Time.time);

            //  transform.LookAt(transform.forward);
            //............
            //this work
                       transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(-90, 0, 0), 0.05f * Time.deltaTime);



        }

        else
            {
              transform.position -= transform.forward * Time.deltaTime * 0.1f;

            }
        }
    }
