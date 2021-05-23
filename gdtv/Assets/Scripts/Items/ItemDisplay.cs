using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDisplay : MonoBehaviour
{

    public Item item;

    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = ItemManager.Instance.GetRandomItem().sprite;
    }

    // Update is called once per frame
    public void SetItem(Item item) {
        spriteRenderer.sprite = item.sprite;
    }
}
