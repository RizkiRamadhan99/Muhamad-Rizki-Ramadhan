using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public List<Transform> spawnPoint;
    public int maxEnemy;
    public float spawnInterval;
    public float spawnCount;
    private bool isSpawning = false;


    private void Update()
    {
        spawnInterval -= Time.deltaTime;
        if(isSpawning == false && spawnInterval < 0) EnemySpawn();
    }
    void EnemySpawn()
    {
        isSpawning = true;

        Vector3 spawnPos = Vector3.zero;

        Vector3 randomOffset = Random.insideUnitCircle * 5f;
        GameObject randomEnemy = enemyPrefabs[(Random.RandomRange(0, enemyPrefabs.Length))];

        Transform randomSpawnPoint = spawnPoint[(Random.Range(0, spawnPoint.Count))];
        spawnPos = randomSpawnPoint.position + new Vector3(randomOffset.x, 0f, randomOffset.y);

        Instantiate(randomEnemy, spawnPos, Quaternion.identity);
        spawnCount++;

        isSpawning = false;
        spawnInterval = 1f;
    }
}
