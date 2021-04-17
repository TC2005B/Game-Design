/*
Emilio Sanchez 
Rafael Rios
Edgar Rostro

Checks the points from the User and decides whether the User has won or not  then displays the corresponding message
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    [SerializeField] Text textScore;
    [SerializeField] Text textAttempts;
    [SerializeField] Text textMessage;

    int aciertos = 0;
    int intentos = 3;

    // Update is called once per frame
    public void puntos(bool acierto)
    {
        if (acierto)
        {
            aciertos++;
            textScore.text = "Aciertos: " + aciertos + "/10";
        } 
        else
        {
            intentos--;
            textAttempts.text = "Intentos: " + intentos + "/3";
        }
        menu();
    }

    void menu()
    {
        if (aciertos == 10)
        {
            textMessage.text = "¡FELICIDADES, ENVIASTE LAS SEÑALES CORRECTAS!\nPresiona 'R' para volver a jugar\nPresiona 'M' para continuar con tu aventura";
        }
        if (intentos == 0)
        {
            textMessage.text = "¡PERDISTE, TE QUEDASTE SIN INTENTOS!\nPresiona 'R' para reintentar\nPresiona 'M' para volver al mapa";
        }
        else 
        {
            textMessage.text = "Presiona la tecla 'Espacio' para continuar\nPresiona 'R' para reintentar\nPresiona 'M' para volver al mapa";
        }
    }
}



	
