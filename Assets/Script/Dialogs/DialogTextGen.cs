using UnityEngine;

[CreateAssetMenu]
public class DialogTextGen : ScriptableObject
{
    public DialogText[] dialogTexts;
    private int previosI;

    public DialogText Ganerate()
    {
        int i = Random.Range(0, dialogTexts.Length);
        if(i == previosI)
        {
            i += 1;
        }
        previosI = i;
        return dialogTexts[i++ % dialogTexts.Length];
    }

    public bool IsValidItem(int indexOfItem, int indexItemInText)
    {
        return (indexOfItem == indexItemInText);
    }
}
