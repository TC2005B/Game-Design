/*
Emilio Sanchez 
Rafael Rios
Edgar Rostro

Returns the player to the motherboard (main exploration map) 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Salir : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene("Mapa", LoadSceneMode.Single);
        PlayerPrefs.SetInt("NC", PlayerPrefs.GetInt("NC", 0) + 1);
    }
}