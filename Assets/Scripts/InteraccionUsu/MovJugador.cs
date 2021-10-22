using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovJugador : MonoBehaviour
{
    Rigidbody rb;


    public float valX, valy, speed;

    public Vector3 posOrigen;

    // Start is called before the first frame update
    void Start()
    {
        posOrigen = transform.position;
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        valX = Input.GetAxis("Horizontal");
        valy = Input.GetAxis("Vertical");


        if (transform.position.y < -10f)
        {
            transform.position = posOrigen;
        }
    }



    private void FixedUpdate()
    {
        //rb.position =  posicion actual del objeto/elemento  pos = [x,y,z]
        //Time.fixedDeltaTime = para que el movimiento este acorde con el tiempo
        //valX,valY  =  [-1 a 1] = indica la direccion del movimiento y la idea de velocidad
        //new Vector3(valX, 0, valy)  Desplazamiento que tendrá de la ubicación actual
        //speed esscalar que multiplica la direccion para que el objeto se mueva una mayor distancia

        rb.MovePosition(rb.position + Time.fixedDeltaTime * new Vector3(valX, 0, valy) * speed);

        //Considerar la normalización del desplzamiento, para evitar que aumente la velocidad 
        // de movimiento del objeto cuando este se mueve en diagonal.

    }
}
