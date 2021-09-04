using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * _speed);
        }
    }
}
