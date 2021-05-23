using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Customer
{
    public string name;
    public Item item;

    public Customer(string name, Item item)
    {
        this.name = name;
        this.item = item;
    }
}