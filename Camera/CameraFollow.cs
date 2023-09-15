using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Space]
    [Header("Target")]
    [SerializeField] private Transform _target;

    [Space]
    [Header("Parameters")]
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _timeToReachTarget = 2f;

    private void FixedUpdate()
    {
        Vector3 offsetTargetPosition = _target.position + _offset;

        transform.position = Vector3.Lerp(transform.position, offsetTargetPosition, (_timeToReachTarget * Time.fixedDeltaTime));
    }
}
