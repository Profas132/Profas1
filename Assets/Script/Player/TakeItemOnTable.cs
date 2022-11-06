using UnityEngine;

public class TakeItemOnTable : MonoBehaviour
{
    [SerializeField] private float rayDistance;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Transform takePose;

    void Update()
    {   
        Debug.DrawRay(transform.position, transform.right * rayDistance, Color.red);
        Debug.DrawRay(transform.position, -transform.right * rayDistance, Color.red);
        Debug.DrawRay(transform.position, transform.up * rayDistance, Color.red);
        Debug.DrawRay(transform.position, -transform.up * (rayDistance + 2.5f), Color.red);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
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

                NPSDialog dialog = hitInfoRight.transform.GetComponent<NPSDialog>();
                if (dialog)
                {
                    //dialog.DEBUG();
                    dialog.CheckItemInKarmani(transform);
                }
            }
            else
            if (hitInfoLeft)
            {
                TableSpawner table = hitInfoLeft.transform.GetComponent<TableSpawner>();
                if (table)
                {
                    table.TakeItem(transform);
                }

                NPSDialog dialog = hitInfoLeft.transform.GetComponent<NPSDialog>();
                if (dialog)
                {
                    //dialog.DEBUG();
                    dialog.CheckItemInKarmani(transform);
                }
            }
            else
            if (hitInfoUp)
            {
                TableSpawner table = hitInfoUp.transform.GetComponent<TableSpawner>();
                if (table)
                {
                    table.TakeItem(transform);
                }

                NPSDialog dialog = hitInfoUp.transform.GetComponent<NPSDialog>();
                if (dialog)
                {
                    //dialog.DEBUG();
                    dialog.CheckItemInKarmani(transform);
                }
            }
            else
            if (hitInfoDown)
            {
                TableSpawner table = hitInfoDown.transform.GetComponent<TableSpawner>();
                if (table)
                {
                    table.TakeItem(transform);
                }

                NPSDialog dialog = hitInfoDown.transform.GetComponent<NPSDialog>();
                if (dialog)
                {
                    //dialog.DEBUG();
                    dialog.CheckItemInKarmani(transform);
                }
            }
        }
    }
}
