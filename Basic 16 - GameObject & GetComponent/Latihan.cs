using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan : MonoBehaviour
{
    GameObject siKotak;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Awake()
    {
        siKotak = GameObject.Find("Cube");
        rigidbody = siKotak.GetComponent<Rigidbody>();
        //rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(Vector3.forward * 10);
        rigidbody.useGravity = false;
    }
}
