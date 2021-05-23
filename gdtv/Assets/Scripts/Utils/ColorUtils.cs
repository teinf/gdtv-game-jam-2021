using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorUtils
{
    public static Color GetRandomColor()
    {
        float r = Random.Range(0, 255) / 255f;
        float g = Random.Range(0, 255) / 255f;
        float b = Random.Range(0, 255) / 255f;
        Color color = new Color(r, g, b);
        return color;
    }

    public static Color GetRandomPrettyColor()
    {
        float h = Random.Range(0, 360) / 360f;
        float s = Random.Range(42, 98) / 100f;
        float v = Random.Range(40, 90) / 100f;
        Color color = Color.HSVToRGB(h, s, v);
        return color;
    }
}