using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccionEnemigo : MonoBehaviour
{
    [SerializeField]
    public GameObject enemi;

    // Start is called before the first frame update
    void Start()
    {
       //GameObject.FindGameObjectsWithTag("Enemigo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        string tag = other.gameObject.tag;

        if (tag.Equals("Player"))
        {
            string name = other.gameObject.name;
            GameObject jugador = GameObject.Find(name);

            EnemigoLogica logica = enemi.GetComponent<EnemigoLogica>();
            logica.personajeToAtacar = jugador.transform;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        string tag = other.gameObject.tag;

        if (tag.Equals("Player"))
        {            
            EnemigoLogica logica = enemi.GetComponent<EnemigoLogica>();
            logica.personajeToAtacar = null;
        }
    }

}
