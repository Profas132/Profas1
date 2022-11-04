using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IngredientGen : ScriptableObject
{
    public Ingredient[] ingredients;
    public int ind = 0;

    public Ingredient Generate(int index)
    {
        ind = index;
        return ingredients[ind++ % ingredients.Length];
    }
}
