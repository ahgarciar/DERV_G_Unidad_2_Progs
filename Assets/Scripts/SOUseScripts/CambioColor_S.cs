using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor_S : MonoBehaviour
{
    [SerializeField]
    SO_ColorCubo scriptableObj;

    Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //renderer.material = scriptableObj.material; 
        renderer.material.color = scriptableObj.color;

    }
}
