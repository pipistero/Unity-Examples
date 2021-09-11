using UnityEngine;

[CreateAssetMenu(fileName = "New Crossbow", menuName = "Weapon/Crossbow")]
public class CrossBow : Weapon
{
	[Space]
	[Header("Parameters")]
	[SerializeField] private int _damage;
	[SerializeField] private float _shotPrepareTime;
	[SerializeField] private float _reloadTime;
}

