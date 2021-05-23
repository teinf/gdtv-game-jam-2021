using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance { get; private set; }
    [HideInInspector]
    public Item[] items;
    void Awake()
    {
        if (Instance == null) { Instance = this; } else { Debug.Log("Warning: multiple " + this + " in scene!"); }
        items = Resources.LoadAll<Item>("Items");
    }

    public Item GetRandomItem()
    {
        if (items.Length > 0)
        {
            return items[Random.Range(0, items.Length)];
        }

        return null;
    }

}
