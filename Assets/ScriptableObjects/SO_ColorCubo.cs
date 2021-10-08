using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Config_Cubo", menuName = "ScriptableObjects/CrearConfigCubo", order = 1)]
public class SO_ColorCubo : ScriptableObject
{
    public Color color;
    public Material material;
}
