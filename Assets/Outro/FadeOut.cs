using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    public Image myPanel;
    public float fadeTime = 3f;
    Color colorToFadeTo;


    void Start()
    {
        colorToFadeTo = new Color(1f, 1f, 1f, 0f);
        myPanel.CrossFadeColor(colorToFadeTo, fadeTime, true, true);
    }
}
