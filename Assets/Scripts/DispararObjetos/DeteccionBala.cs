using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeteccionBala : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI txt_puntaje;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        string tag = collision.gameObject.tag;

        if (tag.Equals("Bala"))
        {
            Debug.Log("La bala choco con la pared");
            Destroy(GameObject.Find(collision.gameObject.name));
            txt_puntaje.text = (Convert.ToInt32(txt_puntaje.text) + 1).ToString();
        }
    }
}
