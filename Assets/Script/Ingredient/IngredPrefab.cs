using UnityEngine;
using UnityEngine.UI;

public class IngredPrefab : MonoBehaviour
{
    [SerializeField] private IngredientGen ingredientGen;
    private Ingredient ingredient;
    private SpriteRenderer imageOfIngred;
    [SerializeField] private int index;

    private void Start()
    {
        imageOfIngred = GetComponent<SpriteRenderer>();

        ingredient = ingredientGen.Generate(index);
        imageOfIngred.sprite = ingredient.PhotoOfIngerdient;
    }
}
