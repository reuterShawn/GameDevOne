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
  
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Bullet")) {
            Destroy(gameObject);
            Destroy(other.gameObject);
            FPSPlayer.instance.HandleEnemyDefeat();
            Debug.Log("Enemy hit!");
        }
    }

    IEnumerator FireRoutine() {
            float elapsedTime = 0;
            while (elapsedTime <= moveTime) {
                elapsedTime += Time.deltaTime;
                mainTransform.position += mainTransform.forward * moveSpeed * Time.deltaTime;
                yield return null;
            }
            Destroy(gameObject);
        }

    // Update is called once per frame
    private void Update()
    {
        secondsPerSpawn -= (0.05f * Time.deltaTime);
        if(Time.time - lastSpawnTime >= secondsPerSpawn && FPSPlayer.instance.ShouldSpawn(spawnLocation.position)) {
            lastSpawnTime = Time.time;
            Spawn();
        }
    }

   private void Spawn() {
        GameObject enemyPrefab = enemies[Random.Range(0, enemies.Length)];
        GameObject newEnemy = Instantiate(enemyPrefab);
        newEnemy.transform.position = spawnLocation.position;
    }
}