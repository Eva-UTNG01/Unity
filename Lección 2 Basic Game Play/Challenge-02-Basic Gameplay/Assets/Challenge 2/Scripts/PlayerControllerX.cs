using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
Descripción:  En este script salen los perro al precionar el space y sale uno por el tiempo de disparo con el tiempo de espera 
no salen en glomeración 
Autor: Eva Quintero Carrillo
Date:27/09/2022
**/
public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
      private float tiempoEsp =1;
    private float tiempoDisparo = 0;

    void Update()
    {
      
        /* On spacebar press, send dog
        Se agrega && Time.time > tiempoDisparo quiere decir que el tiempo que ha pasado de inicio del
         juego es mayor al tiempo del siguiente disparo.*/
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > tiempoDisparo)
        {   
            /*el timpo de disparo  es igual al tiempo por segundo  + tiempoEsp quiere decir que
            que se espera un segundo para que vuelva a salir otro objeto*/
            tiempoDisparo = Time.time + tiempoEsp;
            
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

        }
    }
}
