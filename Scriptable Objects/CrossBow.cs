using UnityEngine;

[CreateAssetMenu(fileName = "New Crossbow", menuName = "Weapon/Crossbow")]
public class CrossBow : ScriptableObject
{
	[SerializeField] private string _name;
	[SerializeField] private string _description;

	[SerializeField] private Sprite _sprite;

	[SerializeField] private int _damage;
	[SerializeField] private float _shotPrepareTime;
	[SerializeField] private float _reloadTime;
}

