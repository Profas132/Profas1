using TMPro;
using UnityEngine;

public class NPSDialog : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private DialogTextGen dialogTextGen;
    private DialogText currentText;

    void Start()
    {
        currentText = dialogTextGen.Ganerate();

        //text.text = "Эй сталкер, Я тебя спас, но в благородство играть не буду";
        text.text = currentText.dialogText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
