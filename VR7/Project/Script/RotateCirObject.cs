using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCirObject : MonoBehaviour
{
    int speed = 10;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        do
        {
           
            if(speed == 50)
            {
                transform.Rotate(0f, speed * Time.deltaTime, 0f);
            }
            else
            {
                speed += 10;
                transform.Rotate(0f, speed * Time.deltaTime, 0f);
            }
        }
       
        while (speed == 50);



    }
}
