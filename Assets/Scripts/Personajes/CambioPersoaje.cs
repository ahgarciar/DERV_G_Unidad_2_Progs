using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CambioPersoaje : MonoBehaviour
{
    [SerializeField]
    public SO_Personaje[] personajes;

    [SerializeField]
    public Image imagen;

    [SerializeField]
    public int index;

    public GameObject contenedorNotas;

    [SerializeField]
    public TextMeshProUGUI txt_nombre;

    private void Awake()
    {
        contenedorNotas = GameObject.Find("ContenedorNotas");
        contenedorNotas.SetActive(false);
        Debug.Log(contenedorNotas.name);        
    }


    // Start is called before the first frame update
    void Start()
    {
        index = -1;
    }

    public void goAnterior() {
        if (index >= 1)
        {
            index--;
            imagen.sprite = personajes[index].imagen;
            txt_nombre.text = personajes[index].nombre;
            contenedorNotas.SetActive(false);
        }
        else {
            contenedorNotas.GetComponentInChildren<TextMeshProUGUI>().text = "Ya estas en el primer elemento de la lista";
            contenedorNotas.SetActive(true);            
        }
    }

    public void goSiguiente() {
        if (index < personajes.Length - 1)
        {
            index++;
            imagen.sprite = personajes[index].imagen;
            txt_nombre.text = personajes[index].nombre;
            contenedorNotas.SetActive(false);
        }
        else {
            contenedorNotas.GetComponentInChildren<TextMeshProUGUI>().text = "Ya estas en el último elemento de la lista";
            contenedorNotas.SetActive(true);
        }
    }



}
