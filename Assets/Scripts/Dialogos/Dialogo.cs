using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialogo : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI mensaje;
    [SerializeField]
    Image imagen;


    [SerializeField]
    public SO_Dialogos dialogos;

    int i, i_max;

    [SerializeField]
    Sprite imgDefecto;


    [SerializeField]
    GameObject contenedorDialogo;

    // Start is called before the first frame update
    void Start()
    {
        i = -1;
        i_max = dialogos.getContDialogos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) //atras
        {
            if (i>0)
            {
                i--;
                mensaje.text = dialogos.getDialogo(i);
                imagen.sprite = dialogos.getImagen(i);
                contenedorDialogo.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.S)) //adelante
        {
            if (i<i_max-1)
            {
                i++;
                mensaje.text = dialogos.getDialogo(i);
                imagen.sprite = dialogos.getImagen(i);
                contenedorDialogo.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.Q)) //cerrar dialogo
        {
            i = -1;                
            mensaje.text = "Sin Texto";
            imagen.sprite = imgDefecto;
            contenedorDialogo.SetActive(false);
        }

    }
}
