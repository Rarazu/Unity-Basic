using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatihanGetButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float angka;
    bool tambah;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            tambah = true;
        }

        if (Input.GetButtonUp("Fire1"))
        {
            tambah = false;
        }

        if (tambah)
        {
            angka += Time.deltaTime;
        }

        Debug.Log((int)angka);
    }
}
