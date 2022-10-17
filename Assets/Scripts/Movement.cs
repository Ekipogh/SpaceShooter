using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] Transform player;

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        Vector3 move = new(inputX * speed, 0, inputZ * speed);
        move *= Time.deltaTime;

        player.Translate(move);
    }
}
