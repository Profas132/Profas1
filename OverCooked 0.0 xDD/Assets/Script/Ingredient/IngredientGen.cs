using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IngredientGen : ScriptableObject
{
    public Ingredient[] ingredients;
    public int index = 0;

    public Ingredient Generate(int index)
    { 

        return ingredients[index++ % ingredients.Length];
    }
}
