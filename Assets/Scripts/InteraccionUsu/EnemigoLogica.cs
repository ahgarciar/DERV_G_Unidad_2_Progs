using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoLogica : MonoBehaviour
{
    public Transform personajeToAtacar;

    public float distanciaToPersonaje;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (personajeToAtacar!=null)
        {
            transform.LookAt(personajeToAtacar);

            distanciaToPersonaje = Vector3.Distance(transform.position, personajeToAtacar.position);

            if (distanciaToPersonaje<=15.0f)
            {
                rb.position = Vector3.MoveTowards(transform.position, personajeToAtacar.position, 10f * Time.deltaTime);
            }

        }
    }
}
