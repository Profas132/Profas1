using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ClockTimer : MonoBehaviour
{
    [SerializeField] private float time;
    private Image timerImage;
    [HideInInspector]public float _timeLeft = 0f;

    private void Start()
    {
        timerImage = GetComponent<Image>();
        //ManagerScene.StopGame += DisableTimer;
        _timeLeft = time;
        StartCoroutine(StartTimer());
    }

    private IEnumerator StartTimer()
    {
        while (_timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;
            var normalizedValue = Mathf.Clamp(_timeLeft / time, 0.0f, 1.0f);
            timerImage.fillAmount = normalizedValue;
            yield return null;
        }
    }

    public void DisableTimer()
    {
        //ManagerScene.StopGame -= DisableTimer;
        Destroy(gameObject);
    }
}
