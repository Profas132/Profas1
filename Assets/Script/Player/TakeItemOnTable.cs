using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeItemOnTable : MonoBehaviour
{
    [SerializeField] private float rayDistance;
    [SerializeField] private Inventary inventary;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Transform takePose;

    //private GameObject gameObject;
    private void Start()
    {
        inventary = GetComponentInChildren<Inventary>();
    }

    //private void OnDrawGizmosSelected()
    //{
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawWireSphere(takePose.position, rayDistance);
    //}

    void Update()
    {   
        Debug.DrawRay(transform.position, transform.right * rayDistance, Color.red);
        Debug.DrawRay(transform.position, -transform.right * rayDistance, Color.red);
        Debug.DrawRay(transform.position, transform.up * rayDistance, Color.red);
        Debug.DrawRay(transform.position, -transform.up * (rayDistance + 2.5f), Color.red);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Collider2D[] tables = Physics2D.OverlapCircleAll(takePose.position, rayDistance, layerMask);
            //if (tables.Length != 0)
            //{
            //    for (int i = 0; i < tables.Length; i++)
            //    {
            //        tables[i].GetComponent<TableSpawner>().cum();
            //    }
            //}

            RaycastHit2D hitInfoRight = Physics2D.Raycast(transform.position, transform.right, rayDistance, layerMask);
            RaycastHit2D hitInfoLeft = Physics2D.Raycast(transform.position, -transform.right, rayDistance, layerMask);
            RaycastHit2D hitInfoUp = Physics2D.Raycast(transform.position, transform.up, rayDistance, layerMask);
            RaycastHit2D hitInfoDown = Physics2D.Raycast(transform.position, -transform.up, rayDistance + 3.3f, layerMask);

            if (hitInfoRight)
            {
                TableSpawner table = hitInfoRight.transform.GetComponent<TableSpawner>();
                if (table)
                {
                    table.TakeItem(transform);
                }
            }
            if (hitInfoLeft)
            {
                TableSpawner table = hitInfoLeft.transform.GetComponent<TableSpawner>();
                if (table)
                {
                    table.TakeItem(transform);
                }
            }
            if (hitInfoUp)
            {
                TableSpawner table = hitInfoUp.transform.GetComponent<TableSpawner>();
                if (table)
                {
                    table.TakeItem(transform);
                }
            }
            if (hitInfoDown)
            {
                TableSpawner table = hitInfoDown.transform.GetComponent<TableSpawner>();
                if (table)
                {
                    table.TakeItem(transform);
                }
            }
        }
    }
}
