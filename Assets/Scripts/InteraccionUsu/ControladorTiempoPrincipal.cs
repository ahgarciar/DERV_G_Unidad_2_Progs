using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorTiempoPrincipal : MonoBehaviour
{
    public int contador;

    // Start is called before the first frame update
    void Start()
    {
        contador = 10;

        StopAllCoroutines();
        StartCoroutine("controlTiempo");
    }

    IEnumerator controlTiempo() {
        while (true)
        {
            contador--;
            if (contador==0)
            {
                PlayerPrefs.SetInt("puntuacion", Random.Range(10, 100));
                SceneManager.LoadScene(2);
            }

            yield return new WaitForSeconds(1);
        }
    }     

}
