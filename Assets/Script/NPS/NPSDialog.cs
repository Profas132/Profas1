using TMPro;
using UnityEngine;

public class NPSDialog : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private DialogTextGen dialogTextGen;
    [SerializeField] private UIElements UI;

    [Space][Header("Slider")]
    [SerializeField] private SliderValue slider;
    [SerializeField] private float sliderAddedTime;
    [SerializeField] private float sliderInvalidTime;

    private DialogText currentTextGen;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        GenerateNewDialogText();
    }

    public void CheckItemInKarmani(Transform collition)
    {
        Inventary inventary = collition.GetComponentInChildren<Inventary>();
        for (int i = 0; i < inventary.karmani.Length; i++)
        {
            if (inventary.isFull[i] == true)
            {
                if(!dialogTextGen.IsValidItem(inventary.ingredInInventory[i].index, currentTextGen.indexOfItems))
                {
                    //inventary.karmani[i].DropItem();
                    //UI.score += 1;
                    slider.currentTime -= sliderInvalidTime;
                    Debug.Log("Ќе правильно");
                }
                if (dialogTextGen.IsValidItem(inventary.ingredInInventory[i].index, currentTextGen.indexOfItems)) 
                {
                    inventary.karmani[i].DropItem();
                    UI.score += 1;
                    slider.currentTime += sliderAddedTime;
                    GenerateNewDialogText();
                    Debug.Log("ѕравильно");
                    break;
                }
            }
        }           
    }
        
    private void GenerateNewDialogText()
    {
        currentTextGen = dialogTextGen.Ganerate();
        audioSource.clip = currentTextGen.audioClip;
        //text.text = "Ёй сталкер, я теб€ спас, но в благородство играть не буду";
        audioSource.Play();
        text.text = currentTextGen.dialogText;
    }
}
