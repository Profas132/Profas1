using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIElements : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private ClockTimer timer;
    [SerializeField] private Slider slider;
    [SerializeField] private PauseMenu pauseMenu;

    [Header("Score")]
    [SerializeField] private GameObject scoreWindow;
    [SerializeField] private TextMeshProUGUI winOrLose;
    [SerializeField] private TextMeshProUGUI dataInWindow;
    [SerializeField] private TextMeshProUGUI totalScore;

    public int score;

    private void FixedUpdate()
    {
        scoreText.text = $"Выполнено: {score}";
    }

    public void EndGame(bool win)
    {
        pauseMenu.OnPause();
        scoreWindow.SetActive(true);
        if (win)
        {
            winOrLose.text = "Ты снова лучший и единсвенный работник!";
        }
        else
        {
            winOrLose.text = "Ты больше не хороший мальчик, Eржан";
        }

        float timerScore = timer.time - timer.currentTime;
        dataInWindow.text = $"Выполнено: {score}*5 => {score * 5}. Прошло времени: {timerScore}сек.";
        totalScore.text = $"Итоговый счёт: {(score * 5 * timerScore)}";
    }
}
