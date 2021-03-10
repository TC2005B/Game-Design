using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Salir : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        //lastPosition_ = entrar.lastPosition;
        SceneManager.LoadScene("Mapa", LoadSceneMode.Single);

    }
}

