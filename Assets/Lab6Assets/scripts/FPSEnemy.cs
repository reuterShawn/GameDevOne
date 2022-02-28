using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSEnemy : MonoBehaviour
{
    [SerializeField] private Transform mainTransform;
    [SerializeField] private Transform spawnLocation;
    [SerializeField] private GameObject[] enemies;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float moveTime;
    [SerializeField] private float lastSpawnTime;
    [SerializeField] private float secondsPerSpawn;

 void Start()
    {
        Vector3 playerPos = FPSPlayer.instance.transform.position;
        mainTransform.LookAt(playerPos);
    }
    private void Update()
    {
        secondsPerSpawn -= (0.05f * Time.deltaTime);
        if(Time.time - lastSpawnTime >= secondsPerSpawn && FPSPlayer.instance.ShouldSpawn(spawnLocation.position)) {
            lastSpawnTime = Time.time;
            Spawn();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            FPSPlayer.instance.HandleEnemyDefeat();
        }
    }
    private void Spawn() {
        GameObject enemyPrefab = enemies[Random.Range(0, enemies.Length)];
        GameObject newEnemy = Instantiate(enemyPrefab);
        newEnemy.transform.position = spawnLocation.position;
    }
}