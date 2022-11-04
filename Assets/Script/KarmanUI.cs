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
        for (int i = 0; i < inventary.ingredInInventory.Count; i++)
        {
            image[i].sprite = inventary.ingredInInventory[i].imageOfIngred;
        }
    }
}
