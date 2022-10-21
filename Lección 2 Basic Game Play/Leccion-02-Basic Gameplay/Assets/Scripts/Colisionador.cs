using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/** 
Descripción: Script destruye objetos que colisionan
Autor: Eva Quintero Carrillo
Fecha: 23 sep 2022
*/
public class Colisionador : MonoBehaviour
{
    
    void Start()
    {
        
    }

        void Update()
    {
     
}
   void OnTriggerEnter(Collider other)
        {

            //va a destruir los objetos que tienen el colicionador (paragraps)
            Destroy(gameObject);
        }
    }