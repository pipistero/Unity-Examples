using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.HealthUpdated += OnHealthUpdated;
    }

    private void OnDisable()
    {
        _player.HealthUpdated -= OnHealthUpdated;
    }

    private void OnHealthUpdated(int health)
    {
        DebugHealth(health);
    }

    private void DebugHealth(int currentHealth)
    {
        Debug.Log($"Current health is {currentHealth}");
    }
}
