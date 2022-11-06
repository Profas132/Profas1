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
        //else if (transform.childCount > 0)
        //{

        //}
    }

    public void DropItem()
    {
        foreach (Transform child in transform)
        {
            inventary.ingredInInventory.RemoveAt(i);
            GameObject.Destroy(child.gameObject);
        }
    }
}
