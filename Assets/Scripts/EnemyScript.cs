using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private Transform player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float moveStep = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, player.position, moveStep);
    }
}
