using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guia : MonoBehaviour
{
    [SerializeField] Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target, Vector3.up);
    }
}
