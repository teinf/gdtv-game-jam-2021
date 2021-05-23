using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Customer : MonoBehaviour
{
    public new string name;
    public Item item;

    [SerializeField] GameObject headObject;
    [SerializeField] GameObject bodyObject;

    private void Start()
    {
        var head = CustomerManager.Instance.GetRandomHead();
        var body = CustomerManager.Instance.GetRandomBody();
        SetCustomer(head, body);
    }

    public Customer(string name, Item item)
    {
        this.name = name;
        this.item = item;
    }

    public void SetCustomer(Head head, Body body)
    {
        SetCustomerHead(head);
        SetCustomerBody(body);
        SetHeadOffset(body);
    }

    void SetCustomerHead(Head head)
    {
        SpriteRenderer sr = headObject.GetComponent<SpriteRenderer>();
        sr.sprite = head.sprite;

        float minX = head.headScaleMin.x;
        float maxX = head.headScaleMax.x;

        float minY = head.headScaleMin.y;
        float maxY = head.headScaleMax.y;

        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);


        Vector2 newScale = new Vector2(x, y);
        headObject.transform.localScale = newScale;
    }

    void SetCustomerBody(Body body)
    {
        SpriteRenderer sr = bodyObject.GetComponent<SpriteRenderer>();
        sr.sprite = body.sprite;
    }

    void SetHeadOffset(Body body)
    {
        Vector3 newOffset = body.headOffset;
        headObject.transform.position += newOffset;
    }
}