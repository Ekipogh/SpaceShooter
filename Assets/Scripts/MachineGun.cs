using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    [SerializeField] Transform enemies;
    [SerializeField] Bullet bulletPrefab;
    List<GameObject> bullets;
    int shootCooldown = 0;
    static int shootCooldownMax = 100;

    // Start is called before the first frame update
    void Start()
    {
        bullets = new List<GameObject>(20);
    }

    // Update is called once per frame
    void Update()
    {
        Transform enemy = FindEnemy();
        if (enemy != null)
        {
            //.LookAt(enemies.position);
            if (shootCooldown-- == 0)
            {
                shootCooldown = shootCooldownMax;
                ShootEnemy(enemy);
            }
        }
    }

    private void ShootEnemy(Transform enemy)
    {
        if (bullets.Count < bullets.Capacity)
        {
            Bullet bullet = Instantiate<Bullet>(bulletPrefab, transform.position, transform.rotation);
            bullet.SetTarget(enemy);
        }
    }

    private Transform FindEnemy()
    {
        Transform target_enemy = null;
        float min_distance = float.MaxValue;
        // Find closest enemy
        foreach (Transform enemy in enemies)
        {
            Vector3 enemy_position = enemy.transform.position;
            float distance = Vector3.Distance(enemy_position, transform.position);
            if (distance < min_distance)
            {
                min_distance = distance;
                target_enemy = enemy;
            }
        }
        return target_enemy;
    }
}
