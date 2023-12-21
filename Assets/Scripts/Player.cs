using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] Transform player;
    [SerializeField] Transform camera;
    private float movementX = 0;
    private float movementZ = 0;
    private float lookX = 0f;
    private float lookY = 0f;
    private float lookSpeed = 5f;
    private float cameraYMax = 5f;
    private float cameraYMin = -0.5f;

    // Update is called once per frame
    void Update()
    {
        player.Translate(movementX, 0, movementZ);
        float cameraY = camera.position.y;
        // Rotate camera around player if camera is within bounds
        if (cameraY <= cameraYMax && cameraY >= cameraYMin)
            camera.RotateAround(player.position, Vector3.right, lookY);
        camera.position = new Vector3(camera.position.x, Mathf.Clamp(camera.position.y, cameraYMin, cameraYMax), camera.position.z);
        camera.RotateAround(player.position, Vector3.up, lookX);
        // look at player
        camera.LookAt(player);
        // Z rotation of camera is always 0
        camera.rotation = Quaternion.Euler(camera.rotation.eulerAngles.x, camera.rotation.eulerAngles.y, 0);
    }

    public void OnMove(InputValue value)
    {
        Debug.Log("Moved");
        Vector2 move = value.Get<Vector2>();
        move *= Time.deltaTime * speed;
        movementX = move.x;
        movementZ = move.y;
    }
    public void OnLook(InputValue inputValue)
    {
        Debug.Log("Looked Camera");
        Vector2 look = inputValue.Get<Vector2>();
        lookX = look.x * lookSpeed * Time.deltaTime;
        lookY = look.y * lookSpeed * Time.deltaTime;
    }
}
