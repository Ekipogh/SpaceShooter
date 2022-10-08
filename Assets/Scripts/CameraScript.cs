using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private Transform target;
    private Vector3 startPostion = new Vector3(0, 10, 0);
    private Vector3 velocity = Vector3.zero;
    private float smoothTime = 0.25f;

    void LateUpdate()
    {
        //transform.LookAt(player);
        Vector3 position = target.position + startPostion;
        transform.position = Vector3.SmoothDamp(transform.position, position, ref velocity, smoothTime);
    }
}
