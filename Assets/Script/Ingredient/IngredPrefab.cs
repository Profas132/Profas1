using UnityEngine;
using UnityEngine.UI;

public class IngredPrefab : MonoBehaviour
{
    [SerializeField] private IngredientGen ingredientGen;
    private Ingredient ingredient;
    private SpriteRenderer imageOfIngred;
    public int index;

    private void Start()
    {
        //index = GetComponentInParent<TableSpawner>().index;
        imageOfIngred = GetComponent<SpriteRenderer>();

        //Debug.Log($"{gameObject.name} {index}");

        ingredient = ingredientGen.Generate(index);
        imageOfIngred.sprite = ingredient.PhotoOfIngerdient;
    }
}
