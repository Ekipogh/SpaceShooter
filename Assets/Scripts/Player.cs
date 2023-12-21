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
    private float lookXLimit = 45f;

    // Update is called once per frame
    void Update()
    {
        player.Translate(movementX, 0, movementZ);
        camera.RotateAround(player.position, Vector3.up, lookX);
        camera.RotateAround(player.position, Vector3.right, lookY);
        //camera.localEulerAngles = new Vector3(Mathf.Clamp(camera.localEulerAngles.x, -lookXLimit, lookXLimit), camera.localEulerAngles.y, camera.localEulerAngles.z);
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
