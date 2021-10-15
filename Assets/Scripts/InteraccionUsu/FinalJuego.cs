using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalJuego : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI usuario;
    [SerializeField]
    TextMeshProUGUI puntuacion;

    // Start is called before the first frame update
    void Start()
    {
        string temp;

        temp = PlayerPrefs.GetString("usuario");
        if (temp!=null)
        {
            usuario.text = temp;
        }
        else{ usuario.text = ""; }

        int aux;

        aux = PlayerPrefs.GetInt("puntuacion");

        if (aux != 0) {
            puntuacion.text = aux.ToString();
        }
        else
        {
            aux = -1;
        }
            
    }

    public void volverInicio()
    {
        SceneManager.LoadScene(0);
    }


}
