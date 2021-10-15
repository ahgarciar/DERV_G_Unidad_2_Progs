using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogo_", menuName = "ScriptableObjects/Crear Dialogo", order = 3)]
public class SO_Dialogos : ScriptableObject
{

    [System.Serializable]
    public struct Dialogo
    {
        [SerializeField]
        public SO_Personaje personaje;

        [SerializeField]
        [TextArea(2,5)]
        public string mensaje;

    }

    public Dialogo[] dialogos;


    public int getContDialogos() {
        return dialogos.Length;
    }

    public string getDialogo(int index) {
        return dialogos[index].mensaje;
    }

    public Sprite getImagen(int index)
    {
        return dialogos[index].personaje.imagen;
    }


}
