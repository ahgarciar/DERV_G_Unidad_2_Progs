using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Personaje_", menuName = "ScriptableObjects/Crear Personaje", order = 2)]
public class SO_Personaje : ScriptableObject
{
    public string nombre;
    public Sprite imagen;
}
