using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatihanGetAxis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * 10f * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * 10f * Time.deltaTime;

        transform.Translate(h, 0.0f, v);
    }
}
