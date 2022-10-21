using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**Descripcion:En este script el avión avanza hacia delante.
Autor: Eva Quintero Carrillo
Date:17/09/2022
**/

public class SpinPropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    //Se crea la variable propeller con el valor de 1200 dependiendo como queramos que se mueva la elice 
    private float propeller = 1200;

    void Start()
    {
        
    }

    void Update()
    {
        //en la posicion del avion en rotate se agregael propeller para que este se multiplique por el deltatime y este por segundos
     transform.Rotate(Vector3.forward, propeller * Time.deltaTime);
   
    }
}
