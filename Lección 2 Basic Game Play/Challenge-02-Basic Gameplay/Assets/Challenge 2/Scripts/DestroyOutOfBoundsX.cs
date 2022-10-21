using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
Descripción: Para que se destruyan los objetos que se encuentran en el prefast
Autor: Eva Quintero Carrillo
Date:27/09/2022

**/
public class DestroyOutOfBoundsX : MonoBehaviour
{
    //Se modificaon los valores de las varibles de acuerdo a nuestro escenario
    private float leftLimit = -38;
    private float bottomLimit = -5;

   
    void Update()
    {
        // Destroy dogs if x position less than left limit
        //"<" se cambio por que estaba mal definida  
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
