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
        scoreText.text = $"���������: {score}";
    }

    public void EndGame(bool win)
    {
        pauseMenu.OnPause();
        scoreWindow.SetActive(true);
        if (win)
        {
            winOrLose.text = "�� ����� ������ � ����������� ��������!";
        }
        else
        {
            winOrLose.text = "�� ������ �� ������� �������, E����";
        }

        float timerScore = timer.time - timer.currentTime;
        dataInWindow.text = $"���������: {score}*5 => {score * 5}. ������ �������: {timerScore}���.";
        totalScore.text = $"�������� ����: {(score * 5 * timerScore)}";
    }
}
