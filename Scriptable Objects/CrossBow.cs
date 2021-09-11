using UnityEngine;

[CreateAssetMenu(fileName = "New Crossbow", menuName = "Weapon/Crossbow")]
public class CrossBow : ScriptableObject
{
	[Space]
	[Header("Information")]
	[SerializeField] private string _name;
	[SerializeField] private string _description;

	[Space]
	[Header("Image")]
	[SerializeField] private Sprite _sprite;

	[Space]
	[Header("Parameters")]
	[SerializeField] private int _damage;
	[SerializeField] private float _shotPrepareTime;
	[SerializeField] private float _reloadTime;
}

