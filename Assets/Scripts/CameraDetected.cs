using UnityEngine;

public class CameraDetected : MonoBehaviour
{
    [SerializeField] private GameObject _loseText;



    private void Update()
    {
        Detected();
    }

    private void Detected()
    {
        Ray ray = new Ray(transform.position, transform.forward * 10);

        RaycastHit hit;
        Vector3 dir = new Vector3(transform.localRotation.x, transform.localRotation.y, transform.localRotation.z);
        Debug.DrawRay(transform.position, dir);
        if(Physics.SphereCast(transform.position, 2f, dir, out hit))
        {
            if(hit.collider != null)
            {
                if(hit.collider.gameObject.tag == "Player")
                {
                    _loseText.SetActive(true);
                }
                else if(hit.collider.gameObject.tag != "Player")
                    _loseText.SetActive(false);
            }
        }
    }
}
