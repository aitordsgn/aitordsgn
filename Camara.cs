using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    /*Creamos 3 Vector2: 
     *Origen para determinar la posicion en la que pulsas la primera vez el boton
     *Diferencia es la resta entre la posicion inial y la presente
     *Reset es la posicion inical de la camara
     */
    private Vector2 Origen, Diferencia, reset;
    // El booleano que dice si esta pulsado o no
    private bool drag = false;
    //La posicionZ que tiene la camara
    public float PosicionZ = -10f;
    private void Start()
    {
        //Se setea la posicion de la camara en el Start
        reset = Camera.main.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        //La primera vez que el cursor es pulsado se establece el origen
        if (Input.GetMouseButtonDown(0))
        {
            Origen = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        }
        //Cuando el boton ya esta pulsado
        if (Input.GetMouseButton(0))
        {
            //Se calcula la diferencia
            Diferencia = (Camera.main.ScreenToWorldPoint(Input.mousePosition)) - Camera.main.transform.position;

            if( drag == false)
            {
                drag = true;
            }
        else
        {
                drag = false;
        }
            //Cuando esta drageando, se elige.
       if(drag)
            {
                Camera.main.transform.position = new Vector3 (Origen.x - Diferencia.x, Origen.y - Diferencia.y, PosicionZ);
                
            }
       //Elegir el boton que se usa para resetear la camara
       if(Input.GetMouseButton(1))
            {
                Camera.main.transform.position = reset;
            }
        }
    }
}
