using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;
    private Vector3 startPostion;
    // Start is called before the first frame update
    void Start()
    {
        startPostion = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.position + startPostion;
    }
}
