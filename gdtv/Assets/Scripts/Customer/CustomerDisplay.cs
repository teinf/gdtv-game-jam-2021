using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDisplay : MonoBehaviour
{
    [SerializeField] GameObject headObject;
    [SerializeField] GameObject bodyObject;
    Customer customer;
    Animator customerAnimator;

    void Start()
    {
        customer = CustomerManager.Instance.GetRandomCustomer();
        customerAnimator = GetComponent<Animator>();
        SetCustomer(customer);
    }

    public void SetCustomer(Customer customer)
    {
        SetCustomerHead(customer.head);
        SetCustomerBody(customer.body);
        SetHeadOffset(customer.body);
    }

    void SetCustomerHead(Head head)
    {
        SpriteRenderer sr = headObject.GetComponent<SpriteRenderer>();
        sr.sprite = head.sprite;

        float min = head.headScaleMin;
        float max = head.headScaleMax;

        float scale = Random.Range(min, max);

        Vector2 newScale = new Vector2(scale, scale);
        headObject.transform.localScale = newScale;
    }

    void SetCustomerBody(Body body)
    {
        SpriteRenderer sr = bodyObject.GetComponent<SpriteRenderer>();
        sr.sprite = body.sprite;
    }

    void SetHeadOffset(Body body)
    {
        headObject.transform.position = (Vector2)bodyObject.transform.position + body.headOffset;
    }

    public void WalkOutCustomer()
    {
        customerAnimator.SetBool("wasChecked", true);
        // Stworzyæ Skrypt z CONSTami?
    }
}
