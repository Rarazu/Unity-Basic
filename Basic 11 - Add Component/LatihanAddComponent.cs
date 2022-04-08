using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatihanAddComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         gameObject.AddComponent<Rigidbody>();
         gameObject.AddComponent<ScriptBerubahWarna>();
    }
}
