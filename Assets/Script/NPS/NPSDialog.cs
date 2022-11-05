using TMPro;
using UnityEngine;

public class NPSDialog : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text; 

    void Start()
    {
        text.text = "Эй сталкер, Я тебя спас, но в благородство играть не буду";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
