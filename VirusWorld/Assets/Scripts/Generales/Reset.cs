/*
Emilio Sanchez 
Rafael Rios
Edgar Rostro

Changes the game behaviour according to the players input
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    [SerializeField] string scene;
    [SerializeField] Text textMessage;

    DropElem dropper;
    Tiempo timer;

    void Start()
    {
        dropper = GetComponent<DropElem>();
        timer = GetComponent<Tiempo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(scene);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Mapa");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dropper.startDropping();
            timer.startTimer();
            textMessage.text = "";
        }
    }
}