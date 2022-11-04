using UnityEngine;
using UnityEngine.UI;

public class IngredPrefab : MonoBehaviour
{
    [SerializeField] private IngredientGen ingredientGen;
    private Ingredient ingredient;
    public Sprite imageOfIngred;
    public int index;

    private void Start()
    {
        ingredient = ingredientGen.Generate(index);
        SpriteRenderer spriteOfIngred = GetComponent<SpriteRenderer>();
        //Debug.Log($"{gameObject.name} {index}");

        imageOfIngred = ingredient.PhotoOfIngerdient;
        spriteOfIngred.sprite = ingredient.PhotoOfIngerdient;
    }
}
