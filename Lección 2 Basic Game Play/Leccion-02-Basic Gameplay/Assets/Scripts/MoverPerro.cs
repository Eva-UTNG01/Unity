using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
Descripción: Script Para mover el perro hacia delante
Autor: Eva Quintero Carrillo
Fecha: 23 sep 2022
*/
public class MoverPerro : MonoBehaviour
{
    // Start is called before the first frame update
    public float limiteAnimals = 15;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(transform.position.z < -limiteAnimals){
            Destroy(gameObject);

        }
        //para mover al perro
        transform.Translate(Vector3.forward*Time.deltaTime*15);
        
    }
}
