using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Ingredient;
    [SerializeField] private GameObject player;
    public int index;

    void Start()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("On triger");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ingredient.SetActive(true);
            Ingredient.transform.position = player.transform.position;
            //Debug.Log("Take Ingred");
            //Instantiate(Ingredient, collision.transform);
            GetComponent<IngredPrefab>().IngredGenirateOnTable();
        }
    }
}
