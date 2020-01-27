using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{

    public Wave[] waves;
    public Enemy enemy;

    Wave currentWave;
    int currentWaveNumber;

    int MonsterRemainingToSpawn;
    int MonsterRemainingAlive;
    float nextSpawnTime;

    void Start()
    {
        NextWave();
    }

    void Update()
    {

        if (MonsterRemainingToSpawn > 0 && Time.time > nextSpawnTime)
        {
            MonsterRemainingToSpawn--;
            nextSpawnTime = Time.time + currentWave.timeBetweenSpawns;

            Enemy spawnedEnemy = Instantiate(enemy, this.transform.position, Quaternion.identity) as Enemy;
            spawnedEnemy.OnDeath += OnEnemyDeath;
        }
    }

    void OnEnemyDeath()
    {
        MonsterRemainingAlive--;

        if (MonsterRemainingAlive == 0)
        {
            NextWave();
        }
    }

    void NextWave()
    {
        currentWaveNumber++;
        print("Wave: " + currentWaveNumber);
        if (currentWaveNumber - 1 < waves.Length)
        {
            currentWave = waves[currentWaveNumber - 1];

            MonsterRemainingToSpawn = currentWave.enemyCount;
            MonsterRemainingAlive = MonsterRemainingToSpawn;
        }
    }

    [System.Serializable]
    public class Wave
    {
        public int enemyCount;
        public float timeBetweenSpawns;
    }

}