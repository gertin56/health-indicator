using UnityEngine;

public class HealthPoints: MonoBehaviour
{
    private int _healthPoints = 100;
    private int _minHealtPoints = 0;
    private int _maxHealtPoints = 100;

    private int _changeValue = 10;

    public int Health => _healthPoints;

    public void Increase()
    {
        _healthPoints += _changeValue;

        if (_healthPoints > _maxHealtPoints)
            _healthPoints = _maxHealtPoints;
    }

    public void Decrease()
    {
        _healthPoints -= _changeValue;

        if (_healthPoints < _minHealtPoints)
            _healthPoints = _minHealtPoints;
    }
}
