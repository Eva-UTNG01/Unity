using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
Descripción:  Este script es para que se generen las pelotas en la parte superior 
Autor: Eva Quintero Carrillo
Date:27/09/2022
**/
public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    //Esta variable se comenta o elimina ya que no se requiere
    // private float spawnInterval = 4.0f;


    void Start()
    {
        
   
    /*
    En la funcion se cambia por el Invoke y se retira el spawnInteval que tenia 4 segundos
    */
        Invoke("SpawnRandomBall", startDelay);
    }

    void SpawnRandomBall ()
    {
         //demanera aleatoia que cree un indice
        int aleatorio = Random.Range(0,3);
        
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
    
        // instantiate ball at random spawn location
        //en el arreglo se  cambio por la variable aleatorio esto para que se muestren las diferentes pelotas que setienen
        Instantiate(ballPrefabs[aleatorio], spawnPos, ballPrefabs[aleatorio].transform.rotation);
       
    //Al starDelay se le agrega un intervalo de 1 a 5 segundos y se llama nuevamente a la función.
        startDelay = Random.Range(1,5);
        Invoke("SpawnRandomBall", startDelay);

    }

}
