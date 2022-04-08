using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatihanCoroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BelajarCoroutine());  
    }

    IEnumerator BelajarCoroutine()
    {
        Debug.Log("Bersiap");
        yield return new WaitForSeconds(3);
        Debug.Log("Mulai");
    }
}
