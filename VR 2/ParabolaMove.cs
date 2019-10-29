using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolaMove : MonoBehaviour
{

    protected float Anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Anim += Time.deltaTime;
        Anim %= 100f;
        transform.position=MathParabola.Parabola(Vector3.zero,Vector3.forward*500f,100f,Anim/100f);
    }
}
