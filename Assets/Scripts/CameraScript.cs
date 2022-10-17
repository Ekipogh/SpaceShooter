using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private Transform target;
    private Vector3 startPostion;
    private Vector3 velocity = Vector3.zero;
    private readonly float smoothTime = 0.25f;

    private void Start()
    {
        startPostion = transform.position;
    }

    void LateUpdate()
    {
        //transform.LookAt(player);
        Vector3 position = target.position + startPostion;
        transform.position = Vector3.SmoothDamp(transform.position, position, ref velocity, smoothTime);
    }
}
