using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health = 10;

    public event Action<int> OnHealthUpdated;

    public void DealDamage(int value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException("Dealed damage");

        _health -= value;

        if (OnHealthUpdated != null)
            OnHealthUpdated.Invoke(_health);
    }
}
