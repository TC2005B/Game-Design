using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ubicacion : MonoBehaviour
{
    [SerializeField] Transform [] ubicaciones;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = ubicaciones[Random.Range(0 ,ubicaciones.Length)].position;
    }
}
