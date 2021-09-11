using UnityEngine;

[CreateAssetMenu(fileName = "New Sword", menuName = "Weapon/Sword")]
public class Sword : Weapon
{
    [Space]
    [Header("Parameters")]
    [SerializeField] private int _damage;
    [SerializeField] private float _attackPrepareTime;
}
