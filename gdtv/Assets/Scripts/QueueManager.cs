using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueManager : MonoBehaviour
{
    public static QueueManager Instance { get; private set; }

    public ItemDisplay itemDisplay;
    public CustomerDisplay customerDisplay;

    void Awake()
    {
        if (Instance == null) { Instance = this; } else { Debug.Log("Warning: multiple " + this + " in scene!"); }
    }

    public void NextCustomer()
    {
        Customer customer = CustomerManager.Instance.GetRandomCustomer();
        customerDisplay.SetCustomer(customer);
        itemDisplay.SetItem(customer.item);
        DialogueManager.Instance.StartDialogue(DialogueManager.Instance.GetRandomDialogue(), customer.name);
    }
}
