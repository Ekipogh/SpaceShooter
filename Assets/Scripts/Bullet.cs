using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    private int ticks = 1000;

    // Update is called once per frame
    void Update()
    {
        if (ticks-- == 0)
        {
            Destroy(gameObject);
            return;
        }
        float step = speed * Time.deltaTime;
        transform.position -= transform.forward * step;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
