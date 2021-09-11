using UnityEngine;

[CreateAssetMenu(fileName = "New Bow", menuName = "Weapon/Bow")]
public class Bow : Weapon
{
	[Space]
	[Header("Parameters")]
	[SerializeField] private int _damage;
	[SerializeField] private float _shotPrepareTime;
	[SerializeField] private float _reloadTime;
}
