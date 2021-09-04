using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] private GameObject _door;

    private void Update()
    {
        if(Statistics._key == 2)
        {
            Destroy(_door);
        }
    }
}
