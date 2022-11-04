using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableSpawner : MonoBehaviour
{
    [SerializeField] private IngredPrefab ingredient;
    [SerializeField] private IngredPrefab ingradItem;
    public int indexOnTable;

    void Start()
    {
        IngredPrefab ingred;
        ingred = Instantiate(ingredient, transform);
        ingred.index = indexOnTable;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log("On triger");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Inventary inventary = collision.GetComponentInChildren<Inventary>();
            for (int i = 0; i < inventary.karmani.Length; i++)
            {
                if (inventary.isFull[i] == false)
                {
                    inventary.isFull[i] = true;
                    IngredPrefab ingred = Instantiate(ingradItem, inventary.karmani[i].transform);
                    inventary.ingredInInventory.Add(ingred);
                    ingred.index = indexOnTable;
                    break;
                }
                if(inventary.isFull[i] == true && inventary.ingredInInventory[i].index == indexOnTable)
                {
                    inventary.karmani[i].DropItem();
                    break;
                }
            }
            //IngredPrefab ingred;
            //ingred = Instantiate(ingradItem, player.transform) as IngredPrefab;
            //ingred.index = index;
        }
    }
}
