using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 50f;
    [SerializeField] Transform player;

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(inputX * speed, 0, inputZ * speed);
        move *= Time.deltaTime;

        player.Translate(move);
    }
}
