using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattonHandler : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private HealthPoints _health;

    private void OnEnable()
    {
        _health = FindObjectOfType<Player>().GetComponent<HealthPoints>();
    }

    public void Increace()
    {
        _health.Increase();
        _slider.GetComponent<HealthPointView>().Render(_health);
    }

    public void Decrease()
    {
        _health.Decrease();
        _slider.GetComponent<HealthPointView>().Render(_health);
    }
}
