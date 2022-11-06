using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ClockTimer : MonoBehaviour
{
    [SerializeField] private UIElements uIElements;
    public float time;
    private Image timerImage;
    public float currentTime = 0f;

    private void Start()
    {
        timerImage = GetComponent<Image>();
        //ManagerScene.StopGame += DisableTimer;
        currentTime = time;
        StartCoroutine(StartTimer());
    }

    private IEnumerator StartTimer()
    {
        while (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            var normalizedValue = Mathf.Clamp(currentTime / time, 0.0f, 1.0f);
            timerImage.fillAmount = normalizedValue;
            yield return null;
        }
        GameWin();
    }

    private void GameWin()
    {
        uIElements.EndGame(true);
    }
}
