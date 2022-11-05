using UnityEngine;

[CreateAssetMenu]
public class DialogTextGen : ScriptableObject
{
    public DialogText[] dialogTexts;

    public DialogText Ganerate()
    {
        int i = Random.Range(0, dialogTexts.Length);
        return dialogTexts[i++ % dialogTexts.Length];
    }
}
