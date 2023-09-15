using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private int _health = 10;

    public event Action<int> HealthUpdated;

    public void DealDamage(int value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException("Dealed damage");

        _health -= value;

        HealthUpdated?.Invoke(_health);
    }
}
