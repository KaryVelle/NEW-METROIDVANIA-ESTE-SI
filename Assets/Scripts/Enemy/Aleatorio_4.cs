using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aleatorio_4 : MonoBehaviour
{
    private float velocidad = 2;    //Velocidad de desplazamiento del fantasma

    void Update()
    {
        Debug.Log(velocidad);
        transform.Translate(velocidad * Time.deltaTime, 0, 0);
        if (transform.position.x <9)   //Rango de desplazamieneto en "+X"
            velocidad = -velocidad;
        if (transform.position.x > 2.16f)  //Rango de desplazamieneto en "-X"
            velocidad = -velocidad;
    }
}
