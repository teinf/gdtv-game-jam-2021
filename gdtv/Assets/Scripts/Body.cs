using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Body", menuName = "Body")]
public class Body : ScriptableObject
{
    public new string name;
    public Vector2 headOffset;
    public Sprite sprite;
}
