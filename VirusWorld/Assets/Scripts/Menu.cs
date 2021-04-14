using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void inicio()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Mapa");
    }

    public void opciones()
    {
        SceneManager.LoadScene("Opciones");
    }
}