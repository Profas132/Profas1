using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KarmanUI : MonoBehaviour
{
    [SerializeField] private Inventary inventary;
    [SerializeField] private Image[] image;
    //[SerializeField] private TextMeshProUGUI[] text;

    private void Start()
    {
        inventary = FindObjectOfType<Inventary>();
    }

    private void FixedUpdate()
    {
        for (int i = 0; i < image.Length; i++)
        {
            if (inventary.karmani[i] == inventary.isFull[i])
            {
                image[i].gameObject.SetActive(true);
                //text[i].gameObject.SetActive(true);
                if (inventary.ingredInInventory.Count > 0)
                {
                    image[i].sprite = inventary.ingredInInventory[i].imageOfIngred;
                    //text[i].text = inventary.ingredInInventory[i].nameOfIngerdient;
                }
            }
            if (inventary.karmani[i] != inventary.isFull[i])
            {
                image[i].gameObject.SetActive(false);
                //text[i].gameObject.SetActive(false);
            }
        }
    }
}
