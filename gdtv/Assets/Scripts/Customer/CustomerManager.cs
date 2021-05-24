using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    public static CustomerManager Instance { get; private set; }

    [HideInInspector] public Head[] heads;
    [HideInInspector] public Body[] bodies;

    void Awake()
    {
        if (Instance == null) { Instance = this; } else { Debug.Log("Warning: multiple " + this + " in scene!"); }
        heads = Resources.LoadAll<Head>("Heads");
        bodies = Resources.LoadAll<Body>("Bodies");
    }

    public Head GetRandomHead()
    {
        if (heads.Length > 0)
        {
            int randomIndex = Random.Range(0, heads.Length);
            return heads[randomIndex];
        }

        return null;
    }

    public Body GetRandomBody()
    {
        if (bodies.Length > 0)
        {
            int randomIndex = Random.Range(0, bodies.Length);
            return bodies[randomIndex];
        }

        return null;
    }

    public Customer GetRandomCustomer()
    {
        Head head = CustomerManager.Instance.GetRandomHead();
        Body body = CustomerManager.Instance.GetRandomBody();
        Customer customer = new Customer("Jeff Bezos", ItemManager.Instance.GetRandomItem(), head, body);
        return customer;
    }
}
