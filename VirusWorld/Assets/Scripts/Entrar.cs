using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Entrar : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D col)
    {
        //lastPosition = player.position;
        SceneManager.LoadScene("Puzzle_1", LoadSceneMode.Single);   
    }
}
