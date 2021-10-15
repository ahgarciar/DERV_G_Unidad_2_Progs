using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PantallaInicio : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI usuario;

    public void cambiarEscena()
    {
        string usu = usuario.text;
        Debug.Log(usu);

        PlayerPrefs.SetString("usuario", usu);

        SceneManager.LoadScene(1);       
    }
}
