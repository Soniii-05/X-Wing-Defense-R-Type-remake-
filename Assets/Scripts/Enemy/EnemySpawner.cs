using System;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemySpawnPoint; // posizione di spawn
    public GameObject enemyPrefab; // prefab nemico
    public float firstSpawn; // primo intervallo
    public float spawnInterval; // intervallo tra gli spawn
    public Vector2 spawnForce = new Vector2(-5f, 0f); // direzione della forza (sinistra)

    void Start()
    {
        // ripete lo spawn dei nemici, partendo dalla variabile "spawnInterval" e ogni "spawnInterval" secondi
        InvokeRepeating("SpawnEnemy", firstSpawn, spawnInterval);
    }

    void SpawnEnemy()
    {
        // crea il nemico nella posizione "enemySpawnPoint" con la sua rotazione e posizione
        GameObject enemy = Instantiate(enemyPrefab, enemySpawnPoint.transform.position, Quaternion.identity);

        // ottieni il componente Rigidbody del nemico/prefab e applica la forza al nemico
        Rigidbody2D enemyRigidbody = enemy.GetComponent<Rigidbody2D>();   
        enemyRigidbody.AddForce(spawnForce, ForceMode2D.Impulse);
    }  
}      
