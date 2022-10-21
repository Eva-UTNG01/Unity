using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
Descripcion:En este script el avion se enclinara con las teclas de arriba y abajo
Autor: Eva Quintero Carrillo
Date:17/09/2022
**/

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20;
    public float rotationSpeed;
    public float verticalInput;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate este avanza forwoard//punot 1 forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);//agrege el * Time.deltaTime

    //Se realiza el cambio del right por el left esto para que se inclinen el avion correctamente con las flechas de arriba y abajo
      transform.Rotate(Vector3.left,  rotationSpeed * Time.deltaTime * verticalInput);//punto 3 listo

     
    }
}
