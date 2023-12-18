using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] Transform player;
    private float movementX = 0;
    private float movementZ = 0; 

    // Update is called once per frame
    void Update()
    {
        player.Translate(movementX, 0, movementZ);
    }

    public void OnMove(InputValue value)
    {
        Debug.Log("Moved");
        Vector2 move = value.Get<Vector2>();
        move *= Time.deltaTime * speed;
        movementX = move.x;
        movementZ = move.y; 
    }
    
    public void OnLook(InputValue value)
    {
        Debug.Log("Looked");
    }
}
