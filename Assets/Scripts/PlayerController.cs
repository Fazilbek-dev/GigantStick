using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(CapsuleCollider))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private FixedJoystick _joystickController;
    [SerializeField] private float _speed;

    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector3(_joystickController.Horizontal * _speed, _rb.velocity.y, _joystickController.Vertical * _speed);
        //CheckRotation();
    }

    private void CheckRotation()
    {
        if(_joystickController.Horizontal != 0 || _joystickController.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rb.velocity);
        }
    }
}
