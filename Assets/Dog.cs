using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    Transform trans;
    float velocidad;
        void Start()
    {
        velocidad = 1;
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        trans.position += Vector3.up * Time.deltaTime * velocidad;
    
    }
}
