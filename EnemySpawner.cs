using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 2f;  // Tempo entre spawns
    public float spawnRangeX = 8f;  // Limites do eixo X

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, spawnRate);
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPosition = new Vector3(randomX, transform.position.y, 0);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
