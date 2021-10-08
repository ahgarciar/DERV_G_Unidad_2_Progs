using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    [SerializeField]
    GameObject AreDisparo;
    [SerializeField]
    GameObject Bala;

    private long contBala;

    //Lista/Buffer de objetos instanciables  <---------------------

    // Start is called before the first frame update
    void Start()
    {
        contBala = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject bala = Instantiate(Bala, AreDisparo.transform.position,
                AreDisparo.transform.rotation) as GameObject;

            bala.name = "bala_" + contBala.ToString();
            contBala++;

            Destroy(bala, 3);

        }
    }
}
