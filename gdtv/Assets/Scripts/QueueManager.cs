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
        // Przyda�by si� Event (lub Cu�), gdy jest "NextCustomer", to aktywuj� si� Funkcj� w "CustomerManagerze" i "Customer" w jaki� sensowny Spos�b
    }
}
