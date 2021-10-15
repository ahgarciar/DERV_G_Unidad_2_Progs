using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovImagen : MonoBehaviour
{
    //https://www.youtube.com/watch?v=IbmIiVo4NOs&ab_channel=ThEJasonGM 

    public Texture2D[] frames;
    public int fps = 10;

    void Update()
    {
        int index = (int)(Time.time * fps) % frames.Length;
        GetComponent<RawImage>().texture = frames[index];
    }
}
