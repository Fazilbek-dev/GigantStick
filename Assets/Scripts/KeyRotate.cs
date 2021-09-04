using UnityEngine;

public class KeyRotate : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Statistics._key += 1;
            Destroy(this.gameObject);
        }
    }
}