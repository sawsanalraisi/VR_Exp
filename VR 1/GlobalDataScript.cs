using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalDataScript : MonoBehaviour
{
    Transform target;
    void Update()
    {
        transform.rotation = Quaternion.Inverse(target.rotation);
    }
}
