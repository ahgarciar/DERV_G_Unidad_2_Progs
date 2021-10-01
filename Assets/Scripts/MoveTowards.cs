using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    [SerializeField]
    GameObject objDestino;

    [SerializeField]
    float velocidad;

    Vector3 currentVelocity = new Vector3(0f, 0f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }    

    // Update is called once per frame
    void Update()
    {
        Vector3 origen = transform.position;
        Vector3 destino = objDestino.transform.position;

        destino.x -= 2;
        destino.z -= 2;

        /*
        if (origen.x>destino.x)
        {

        }
        */

        //move towars
        //transform.position = Vector3.MoveTowards(origen, destino, velocidad * Time.deltaTime);

        //lerp
        //transform.position = Vector3.Lerp(origen, destino, velocidad * Time.deltaTime);

        //smoothdamp        
        transform.position = Vector3.SmoothDamp(origen, destino, ref currentVelocity, velocidad * Time.deltaTime);

    }
}
