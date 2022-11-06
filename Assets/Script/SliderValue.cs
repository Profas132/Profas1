using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    public float time;
    private Slider slider;
    [HideInInspector] public float currentTime = 0f;

    private void Start()
    {
        slider = GetComponent<Slider>();
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
            slider.value = normalizedValue;
            yield return null;
        }
        GetComponentInParent<UIElements>().EndGame(false);
    }
}
