using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIElements : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private ClockTimer timer;
    [SerializeField] private Slider slider;
    public int score;

    private void FixedUpdate()
    {
        scoreText.text = $"Выполнено: {score}";
    }

    public void EndGame(bool win)
    {

    }
}
