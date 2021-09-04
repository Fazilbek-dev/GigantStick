using UnityEngine;

public class JumpOnTable : MonoBehaviour
{
    [SerializeField] private Transform _targerTable;
    [SerializeField] private float _dist;


    private void Update()
    {
        DistanceOfTarget(this.transform.position, _targerTable.position);
    }

    private void DistanceOfTarget(Vector3 selfPos, Vector3 _targetPos)
    {
        float dis = Vector3.Distance(selfPos, _targetPos);
        if(dis < 7)
        {
            selfPos.y += _dist;
        }
    }
}
