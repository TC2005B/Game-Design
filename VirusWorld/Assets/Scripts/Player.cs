using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidad;

    Vector3 direccion;

    // Registra input de direcciones y mueve al jugador
    void Update()
    {
        SpriteRenderer rendererRobot = GetComponent <SpriteRenderer> ();
        direccion.x = Input.GetAxisRaw("Horizontal");
        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            rendererRobot.flipX = false;
        }
        else if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == 0)
        {
            rendererRobot.flipX = true;
        }
        direccion.y = Input.GetAxisRaw("Vertical");
        transform.position = transform.position + direccion * velocidad;
    }
}
