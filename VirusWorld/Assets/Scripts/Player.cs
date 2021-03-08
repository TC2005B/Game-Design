using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float velocidad;

    Vector3 direccion;

    // Registra input de direcciones y mueve al jugador
    void Update()
    {
        SpriteRenderer rendererRobot = GetComponent <SpriteRenderer> ();
        direccion.x = Input.GetAxisRaw("Horizontal");
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            rendererRobot.flipX = true;
        //    transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
        else if (Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Horizontal") == 0)
        {
            rendererRobot.flipX = false;
            // transform.localScale = new Vector3(transform.localScale.x * 1, transform.localScale.y, transform.localScale.z);
        }
        direccion.y = Input.GetAxisRaw("Vertical");
        transform.position = transform.position + direccion * velocidad;
    }
}
