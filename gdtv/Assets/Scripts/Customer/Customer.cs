using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Customer
{
    public string name;
    public Item item;
    public Head head;
    public Body body;

    public Customer(string name, Item item, Head head, Body body)
    {
        this.name = name;
        this.item = item;
        this.head = head;
        this.body = body;
    }
}