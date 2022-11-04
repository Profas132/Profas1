using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karman : MonoBehaviour
{
    private Inventary inventary;
    [SerializeField] private int i;

    private void Start()
    {
        inventary = GetComponentInParent<Inventary>();
    }

    void Update()
    {
        if (transform.childCount <= 0)
        {
            inventary.isFull[i] = false;
        }
    }

    public void DropItem()
    {
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
            inventary.ingredInInventory.RemoveAt(i);
        }
    }
}
