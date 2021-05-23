using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Head", menuName = "Head")]
public class Head : ScriptableObject
{
    public new string name;
    public Vector2 headScaleMin = new Vector2(0.8f, 0.8f);
    public Vector2 headScaleMax = new Vector2(1.3f, 1.3f);
    public Sprite sprite;
}
