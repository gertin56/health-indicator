using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthPointView : MonoBehaviour
{
    private Slider _slider;
    private float _currentSliderValue;
    private float _newSliderValue;
    private Coroutine _coroutine;

    private void OnEnable()
    {
        _slider = GetComponent<Slider>();
        _currentSliderValue = _slider.value;
    }

    public void Render(HealthPoints healthPoints)
    {
        _newSliderValue = healthPoints.Health;
        StartChange();
    }

    private void StartChange()
    {
        if(_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }

        _coroutine = StartCoroutine(ChangeHealthBar(_newSliderValue));
    }

    private IEnumerator ChangeHealthBar(float targetValue)
    {
        float delta = 3f;

        while (_currentSliderValue != targetValue)
        {
            _currentSliderValue = Mathf.MoveTowards(_currentSliderValue, targetValue, delta * Time.deltaTime);
            _slider.value = _currentSliderValue;
            yield return null;
        }
    }
}
