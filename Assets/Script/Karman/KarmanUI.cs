using UnityEngine;
using UnityEngine.UI;

public class KarmanUI : MonoBehaviour
{
    [SerializeField] private Inventary inventary;
    [SerializeField] private Image[] image;

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
                if (inventary.ingredInInventory.Count > 0) image[i].sprite = inventary.ingredInInventory[i].imageOfIngred;
            }
            if (inventary.karmani[i] != inventary.isFull[i])
            {
                image[i].gameObject.SetActive(false);
            }
        }
    }
}
