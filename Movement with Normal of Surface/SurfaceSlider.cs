using UnityEngine;

public class SurfaceSlider : MonoBehaviour
{
    private Vector3 _normalOfCollision;

    public Vector3 Project(Vector3 forward)
    {
        return forward - Vector3.Dot(forward, _normalOfCollision) * _normalOfCollision;
    }

    private void OnCollisionEnter(Collision collision)
    {
        _normalOfCollision = collision.contacts[0].normal;
    }
}
