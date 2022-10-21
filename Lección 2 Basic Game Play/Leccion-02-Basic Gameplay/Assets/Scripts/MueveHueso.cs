using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
Descripción: Script Para mover los huesos y destruir el objeto
Autor: Eva Quintero Carrillo
Fecha: 23 sep 2022
*/
public class MueveHueso : MonoBehaviour
{
    // Start is called before the first frame update
    public float distancia = 25;

  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        //es para destruir al objeto (hueso)
        if(transform.position.z > distancia){
            Destroy(gameObject);

        }
        //es para mover el hueso
        transform.Translate(Vector3.forward*Time.deltaTime*20);
    }
}
