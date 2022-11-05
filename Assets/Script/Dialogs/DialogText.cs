using System;
using UnityEngine;

[Serializable]
public class DialogText
{
    [TextArea(3,10)] public string dialogText;
    public int indexOfItems;
    public string nameOfItem;
}
