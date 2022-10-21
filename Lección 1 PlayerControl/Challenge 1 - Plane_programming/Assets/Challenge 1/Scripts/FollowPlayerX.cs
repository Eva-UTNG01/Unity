using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
Descripcion:En este script la camara seguira al avion 
Autor: Eva Quintero Carrillo
Date:17/09/2022
**/

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(30,0,10);//punto 5 camara sigue al avión con las siguientes cordenadas

    void Start()
    {

    }

    void Update()
    {
        //se establecera la posición de la camara en la posición del jugador
        transform.position = plane.transform.position + offset ;
    }
}
