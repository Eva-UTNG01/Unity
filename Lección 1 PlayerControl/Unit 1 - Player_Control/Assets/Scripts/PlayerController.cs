using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
Descripción: Este script lo que hace es mover el objeto y poder rotarlo 
Autor: Eva Quintero Carrillo
Fecha: 14/2022
**/

public class PlayerController : MonoBehaviour
{
        //para la velocidad
       private float velocidad =30;
        private float velGiro =20;
    //dos metodos y este metodo se ejecuta cuando se ejecuta el juego
    //variable privada para que no este constantemente creando la variable(para avanzar)
    private float avanza;
    //para girar  -*-*-*
    private float gira;

    void Start()
    {
        
    }

    // Update is called once per frame
    //se ejecuta constantemente
    void Update()
    {     
        //para avanzar(para avanzar)
         avanza = Input.GetAxis("Vertical");
        //   -*-*-*
         gira = Input.GetAxis("Horizontal");
        //Z(1 azul) Y subir() Z atras()
        transform.Translate(Vector3.forward*Time.deltaTime*velocidad*avanza);
        //girar -*-*-*//si no mantengo precionada la tecla de giro sera estatico
        transform.Rotate(Vector3.up, Time.deltaTime*velGiro*gira);
    }
}
