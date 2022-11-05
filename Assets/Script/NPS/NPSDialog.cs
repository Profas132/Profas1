using TMPro;
using UnityEngine;

public class NPSDialog : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private DialogTextGen dialogTextGen;
    private DialogText currentTextGen;

    void Start()
    {
        GenerateNewDialogText();
    }

    public void DEBUG()
    {
        Debug.Log("������");
    }

    public void CheckItemInKarmani(Transform collition)
    {
        Inventary inventary = collition.GetComponentInChildren<Inventary>();
        for (int i = 0; i < inventary.karmani.Length; i++)
        {
            if (inventary.isFull[i] == true && dialogTextGen.IsValidItem(inventary.ingredInInventory[i].index, currentTextGen.indexOfItems))
            {
                inventary.karmani[i].DropItem();
                GenerateNewDialogText();
                Debug.Log("���������");
                break;
            }
        }
    }

    private void GenerateNewDialogText()
    {
        currentTextGen = dialogTextGen.Ganerate();

        //text.text = "�� �������, � ���� ����, �� � ������������ ������ �� ����";
        text.text = currentTextGen.dialogText;
    }
}
