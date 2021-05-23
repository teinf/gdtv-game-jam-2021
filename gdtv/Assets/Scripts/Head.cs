using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Head", menuName = "Head")]
public class Head : ScriptableObject
{
    public new string name;
    public float headScaleMin = 0.8f;
    public float headScaleMax = 1.3f;
    public Sprite sprite;
}
