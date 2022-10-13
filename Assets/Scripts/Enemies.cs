using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    [SerializeField] private static int enemyMax = 10;
    private int enemyCount = 0;
    public GameObject enemyPrefab;
    private int spawnTicker = 0;
    public static bool endPhase = false;

    private static readonly int spawnTickerDefault = 1000;
    private static readonly int randomX = 30;
    private static readonly int randomZ = 30;

    // Update is called once per frame
    void Update()
    {
        if (spawnTicker-- == 0 && enemyCount++<enemyMax)
        {
            spawnTicker = spawnTickerDefault;


            float x = transform.position.x - Random.Range(-randomX, randomX);
            float z = transform.position.z - Random.Range(-randomZ, randomZ);
            GameObject spawnedEnemy = Instantiate(enemyPrefab, new Vector3(x, 0, z), Quaternion.identity);
            spawnedEnemy.transform.parent = gameObject.transform;
        }
        if(enemyCount == enemyMax)
        {
            endPhase = true;
        }
    }
}
