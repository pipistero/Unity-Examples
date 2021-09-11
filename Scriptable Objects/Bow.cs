using UnityEngine;

[CreateAssetMenu(fileName = "New Bow", menuName = "Weapon/Bow")]
public class Bow : ScriptableObject
{
	[SerializeField] private string _name;
	[SerializeField] private string _description;

	[SerializeField] private Sprite _sprite;

	[SerializeField] private int _damage;
	[SerializeField] private float _shotPrepareTime;
	[SerializeField] private float _reloadTime;
}
