using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
Descripción: Script donde crea varios huesos y mueve al jugador de izquierda a derecha
Autor: Eva Quintero Carrillo
Fecha: 23 sep 2022
*/
public class PlayerController : MonoBehaviour
{
    //creo este -*-*-*-*-*
    //esto para sacar muchos huesos *-*-*-*-* este hace referencia al objeto 
      public GameObject proyectilHueso;
    // Start is called before the first frame update
    float horInput;
    //para que el monito no se caiga del tablero ***********----------

    
    float limiteMov = 20;
    void Start()
    {
        
    }

    void Update()
    { 
        //se crea la condicion ***********----------
        //Vector es para posicionar X y Y en Z
        if(transform.position.x > limiteMov){ //derecha
            transform.position = new Vector3(limiteMov,transform.position.y, transform.position.z);

        }
         if(transform.position.x < -limiteMov){ //izquierda
            transform.position = new Vector3(-limiteMov,transform.position.y, transform.position.z);

        }
        
        //esto para sacar muchos huesos *-*-*-*-*
        if(Input.GetKeyDown(KeyCode.Space)){
            //la instacia es lo contrario de destroy para crear un hueso en la posicion del jugador
            Instantiate(proyectilHueso, transform.position,
            proyectilHueso.transform.rotation);

        }

        //left o right
    //para moverlo con el teclado con esto el mono se mueve izquierda y derecha
     horInput   = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*20*horInput);
    }
}
