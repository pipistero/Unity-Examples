using UnityEngine;

public abstract class Weapon : ScriptableObject
{
    [Space]
    [Header("Information")]
    [SerializeField] private string _name;
    [SerializeField] private string _description;

    [Space]
    [Header("Image")]
    [SerializeField] private Sprite _sprite;
}
