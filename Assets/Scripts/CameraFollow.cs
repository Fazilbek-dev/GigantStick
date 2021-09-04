using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _targetPos;
    [SerializeField] private Transform _selfPos;

    private void Update()
    {
        _selfPos.position = _targetPos.position;
    }
}
