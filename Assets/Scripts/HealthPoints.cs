using UnityEngine;
using UnityEngine.Events;

public class HealthPoints: MonoBehaviour
{
    [SerializeField] private UnityEvent _healthChange;

    private int _healthPoints = 100;
    private int _minHealtPoints = 0;
    private int _maxHealtPoints = 100;

    public int Health => _healthPoints;

    public void Increase(int changeValue)
    {
        _healthPoints += changeValue;

        if (_healthPoints > _maxHealtPoints)
            _healthPoints = _maxHealtPoints;

        _healthChange.Invoke();
    }

    public void Decrease(int changeValue)
    {
        _healthPoints -= changeValue;

        if (_healthPoints < _minHealtPoints)
            _healthPoints = _minHealtPoints;

        _healthChange.Invoke();
    }
}
