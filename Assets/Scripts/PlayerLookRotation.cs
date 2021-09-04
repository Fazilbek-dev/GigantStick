using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookRotation : MonoBehaviour
{
    [SerializeField] private FixedJoystick _joystickController;
    [SerializeField] private Animator _playerAnim;
    [SerializeField] private Rigidbody _rb;

    private void FixedUpdate()
    {
        CheckRotation();
    }

    private void CheckRotation()
    {
        if (_joystickController.Horizontal != 0 || _joystickController.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rb.velocity);
            _playerAnim.SetBool("isRun", true);
        }
        else if(_joystickController.Horizontal == 0 && _joystickController.Vertical == 0)
        {
            _playerAnim.SetBool("isRun", false);
        }
    }
}
