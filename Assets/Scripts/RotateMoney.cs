using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class RotateMoney : MonoBehaviour
{
    [SerializeField] private float _speedRotate;
    [SerializeField] private bool _isCoin;
    [SerializeField] private int _countMoney;

    private void Update()
    {
        if(_isCoin)
            transform.Rotate(0, _speedRotate * Time.deltaTime, 0);
        transform.Rotate(0, 0, _speedRotate * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Statistics._moneyCount += _countMoney;
        }
    }
}
