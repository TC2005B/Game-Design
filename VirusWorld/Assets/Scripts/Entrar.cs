using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Entrar : MonoBehaviour
{
    public Transform checkpoint;
    public string scene;
    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerPrefs.SetFloat("X", checkpoint.position.x);
        PlayerPrefs.SetFloat("Y", checkpoint.position.y);
        SceneManager.LoadScene(scene, LoadSceneMode.Single);   
    }
}
