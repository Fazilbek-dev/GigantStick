using UnityEngine;

public class AIBossWalk : MonoBehaviour
{
    [SerializeField] private Transform _playerPos;
    [SerializeField] private float _speed = 3.0f;
    [SerializeField] private float _obstacleRange = 10.0f;
    [SerializeField] private float _offset = 3f;
    [SerializeField] private float _rotSpeed = 3f;

    private Animator _animBoss;
    private void Awake()
    {
        _animBoss = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Statistics._key == 2)
        {
            transform.Translate(0, 0, _speed * Time.deltaTime);
            CheckObsctacle();
        }
    }

    private void CheckObsctacle()
    {
        this.transform.LookAt(_playerPos);
        float dis = Vector3.Distance(this.transform.position, _playerPos.position);
        if (dis < 3)
        {
            _animBoss.SetBool("isAttack", true);
            Statistics._health -= 1;
        }
        else
            _animBoss.SetBool("isAttack", false);
    }
}
