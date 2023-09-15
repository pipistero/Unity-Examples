using UnityEngine;
using UnityEngine.UI;

public class WeaponView : MonoBehaviour
{
    [Header("Images")]
    [SerializeField] private Image _icon;

    [Header("Texts")]
    [SerializeField] private Text _name;
    [SerializeField] private Text _description;

    private Weapon _weapon;

    public void Initialize(Weapon weapon)
    {
        _weapon = weapon;

        _icon.sprite = _weapon.Icon;

        _name.text = _weapon.Name;
        _description.text = _weapon.Description;
    }

    public void ResetView()
    {
        _icon.sprite = null;

        _name.text = string.Empty;
        _description.text = string.Empty;
    }
}