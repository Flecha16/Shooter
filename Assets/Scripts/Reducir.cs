using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reducir : MonoBehaviour
{
    public float puntajeDeObjeto = 1.0f;
    public puntaje pt;

    private void Start() {
        pt = FindObjectOfType<puntaje>();
    }

    void  OnTriggerEnter (  Collider other   ){
        if (other.tag == "bala")//Si toca el tag "bala". 
        {
            pt.puntos += puntajeDeObjeto;
            Destroy(other.gameObject);//Destruye la bala.
        }
    }
}
