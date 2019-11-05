using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManger : MonoBehaviour
{

    private static DataManger instance;


     public bool IsMoveCar;


    public static DataManger Instance
    {
        get
        {
            if (instance == null)
                instance = new DataManger();

            return instance;

        }


    }


}
