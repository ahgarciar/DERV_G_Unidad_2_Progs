using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    [SerializeField]
    GameObject AreDisparo;
    [SerializeField]
    GameObject Bala;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject bala = Instantiate(Bala, AreDisparo.transform.position,
                AreDisparo.transform.rotation) as GameObject;

            Destroy(bala, 3);

        }
    }
}
