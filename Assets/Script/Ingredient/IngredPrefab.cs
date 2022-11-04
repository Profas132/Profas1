using UnityEngine;
using UnityEngine.UI;

public class IngredPrefab : MonoBehaviour
{
    [SerializeField] private IngredientGen ingredientGen;
    private Ingredient ingredient;
    private Image imageOfIngred;
    [SerializeField] private int index;

    public void IngredGenirateOnTable()
    {
        imageOfIngred = GetComponent<Image>();
        
        ingredient = ingredientGen.Generate(index);
        imageOfIngred.sprite = ingredient.PhotoOfIngerdient;
    }
}
