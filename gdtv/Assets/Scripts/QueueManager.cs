using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueManager : MonoBehaviour
{
    public static QueueManager Instance { get; private set; }

    public ItemDisplay itemDisplay;

    void Awake()
    {
        if (Instance == null) { Instance = this; } else { Debug.Log("Warning: multiple " + this + " in scene!"); }
    }

    public void NextCustomer()
    {
        itemDisplay.SetItem(ItemManager.Instance.GetRandomItem());
        // Przyda³by siê Event (lub Cuœ), gdy jest "NextCustomer", to aktywuj¹ siê Funkcjê w "CustomerManagerze" i "Customer" w jakiœ sensowny Sposób
    }
}
