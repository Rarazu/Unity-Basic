using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatihanDebug : MonoBehaviour
{
    //int a = 1;
    public Transform kotakPos;
    //public Transform bolaPos;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Latihan Debug");
        //Debug.Log(1 + 1);
        //Debug.Log(a);
        //Debug.Log("Nilai A adalah " + a);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.DrawLine(kotakPos.position, 
        //bolaPos.position,
        //Color.red);

        Vector3 forward = kotakPos.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(kotakPos.position, forward, Color.red);
    }
}
