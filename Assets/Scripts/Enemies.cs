using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    private List<GameObject> enemyList;
    public GameObject enemyPrefab;
    private int spawnTicker = 0;

    private static readonly int spawnTickerDefault = 1000;
    private static readonly int randomX = 30;
    private static readonly int randomZ = 30;
    // Start is called before the first frame update
    void Start()
    {
        enemyList = new List<GameObject>(5);
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTicker-- == 0 && enemyList.Count != enemyList.Capacity)
        {
            spawnTicker = spawnTickerDefault;


            float x = transform.position.x - Random.Range(-randomX, randomX);
            float z = transform.position.z - Random.Range(-randomZ, randomZ);
            GameObject spawnedEnemy = Instantiate(enemyPrefab, new Vector3(x, 0, z), Quaternion.identity);
            spawnedEnemy.transform.parent = gameObject.transform;
            enemyList.Add(spawnedEnemy);
        }
    }
}
