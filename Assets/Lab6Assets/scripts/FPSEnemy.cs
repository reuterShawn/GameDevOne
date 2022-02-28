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
        
    }
     void Update()
    {
        Vector3 playerPos = FPSPlayer.instance.transform.position;
        mainTransform.LookAt(playerPos);

        Vector3 currentRotation = mainTransform.rotation.eulerAngles;
        currentRotation.x = 0;
        mainTransform.eulerAngles = currentRotation;
        Vector3 directionToPlayer = (playerPos - mainTransform.position).normalized;
        mainTransform.position += (directionToPlayer * moveSpeed * Time.deltaTime).SetY(0);
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
            Debug.Log("Enemy Killed HandleEnemyDefeat Called");
        }
    }
    private void Spawn() {
        GameObject enemyPrefab = enemies[Random.Range(0, enemies.Length)];
        GameObject newEnemy = Instantiate(enemyPrefab);
        newEnemy.transform.position = spawnLocation.position;
    }
}