using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkManager : MonoBehaviour
{
    public static WalkManager Instance { get; private set; }


    Animator customerAnimator;

    void Awake()
    {
        if (Instance == null) { Instance = this; } else { Debug.Log("Warning: multiple " + this + " in scene!"); }
    }

    public void FindCustomerAnimator()
    {
        customerAnimator = FindObjectOfType<CustomerDisplay>().GetComponent<Animator>();
    }

    public void ExitCustomer()
    {
        customerAnimator.SetBool("wasChecked", true);
        // Stworzyæ Skrypt z CONSTami?
    }
}
