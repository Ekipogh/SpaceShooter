using UnityEngine;
using UnityEngine.InputSystem;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform target;
    private Vector3 startPostion;
    private Vector3 velocity = Vector3.zero;
    private readonly float smoothTime = 0.25f;
    private readonly float lookSpeed = 5f;
    private float lookX = 0f;
    private float lookY = 0f;

    private void Start()
    {
        startPostion = transform.position;
    }

    void LateUpdate()
    {
        //transform.LookAt(player);
        Vector3 position = target.position + startPostion;
        transform.position = Vector3.SmoothDamp(transform.position, position, ref velocity, smoothTime);
        transform.eulerAngles = transform.eulerAngles - new Vector3(lookX, lookY, 0);
    }

    public void OnLook(InputValue value)
    {
        Vector2 look = value.Get<Vector2>();
        look *= lookSpeed * Time.deltaTime;
        lookX = look.x;
        lookY = look.y;
    }
}
