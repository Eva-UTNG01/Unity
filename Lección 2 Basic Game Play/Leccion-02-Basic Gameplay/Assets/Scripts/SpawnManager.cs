using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** 
Descripción: Script donde los animales salen aleatoriamente
Autor: Eva Quintero Carrillo
Fecha: 23 sep 2022
*/
public class SpawnManager : MonoBehaviour
{
    //este crea todos los animales
    //prefast
    public GameObject[] arrDogs;

    
    void Start()
    {   //invoca una funcion en un determinado lapso de tiempo
        InvokeRepeating("CreateAnimal",1.5F,1.5F);
       
    }

   
    void Update()
    {
     
    }
    //metodo para crear los objetos para no utilizar la tecla p
    void CreateAnimal(){
         //demanera aleatoia que cree un indice
        int aleatorio = Random.Range(0,3);
        int valX = Random.Range(-20,20);
        //instancea cada que salgan animales de manera aleatoria 
           Instantiate(arrDogs[aleatorio], 
                        new Vector3(valX,
                        0, 11), 
                        arrDogs[aleatorio].transform.rotation);
        
    }
}
