using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.OnHealthUpdated += PrintUpdatedHealth;
    }

    private void OnDisable()
    {
        _player.OnHealthUpdated -= PrintUpdatedHealth;
    }

    private void PrintUpdatedHealth(int health)
    {
        if (_player == null)
            return;

        Debug.Log($"Updated health is {health}");
    }
}
