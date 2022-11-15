using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPointView : MonoBehaviour
{
    private Slider _slider;
    private float _currentSliderValue;
    private float _newSliderValue;

    private HealthPoints health;

    private void OnEnable()
    {
        _slider = GetComponent<Slider>();
        _currentSliderValue = _slider.value;
    }

    public void Render(HealthPoints healthPoints)
    {
        _newSliderValue = healthPoints.Health;
        StartCoroutine(ChangeHealthBar(_currentSliderValue, _newSliderValue));
        _currentSliderValue = _newSliderValue;
    }

    private IEnumerator ChangeHealthBar(float currentValue, float targetValue)
    {
        float delta = 3f;

        while (currentValue != targetValue)
        {
            currentValue = Mathf.MoveTowards(currentValue, targetValue, delta * Time.deltaTime);
            _slider.value = currentValue;
            yield return null;
        }
    }
}
