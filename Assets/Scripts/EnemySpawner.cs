using System;
using Unity.Mathematics;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemySpawnPoint; // Riferimento all'oggetto che definisce la posizione di spawn
    public GameObject enemyPrefab; // Prefab del nemico
    public float spawnInterval = 1.0f; // Tempo tra gli spawn
    public Vector2 spawnForce = new Vector2(-5f, 0f); // Direzione della forza (ad esempio, verso sinistra)

    void Start()
    {
        // Inizia a spawnare nemici ripetutamente, partendo subito (0f) e ogni spawnInterval secondi
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // Usa la posizione dell'oggetto vuoto come punto di spawn
        GameObject enemy = Instantiate(enemyPrefab, enemySpawnPoint.transform.position, Quaternion.identity);

        // Ottieni il componente Rigidbody2D del nemico
        Rigidbody2D enemyRigidbody = enemy.GetComponent<Rigidbody2D>();



        // Applica la forza al nemico
        enemyRigidbody.AddForce(spawnForce, ForceMode2D.Impulse);

    }




        /*
        public GameObject enemy; //cosa crea
        public Transform[] enemyMuzzle; //dove lo crea
        public float enemyForce; //forza con la quale il nemico viene spinto
        private int currentMuzzleIndex = 0; //indice iniziale

        public void Update()
        {
            // Crea il proiettile nella posizione e rotazione del muzzle corrente
            GameObject projectile = Instantiate(enemy, enemyMuzzle[currentMuzzleIndex].position, enemyMuzzle[currentMuzzleIndex].rotation);
            projectile.GetComponent<Rigidbody2D>().AddForce(enemyMuzzle[currentMuzzleIndex].right * enemyForce, ForceMode2D.Impulse);

            // Incrementa l'indice del muzzle
            currentMuzzleIndex = (currentMuzzleIndex + 1) % enemyMuzzle.Length; // Cicla attraverso gli indici
        }
        */


        /*
        [SerializeField] private Transform muzzle;
        [SerializeField] private Direction bulletDirection;
        [SerializeField] private GameObject bulletToSpawn;

        [SerializeField] private float fireRate = 2f;
        private float _currentTime = 0f;

        private void Update()
        {
            _currentTime += Time.deltaTime;

            if (_currentTime >= fireRate)
            {
                GameObject projectile = Instantiate(bulletToSpawn, muzzle.position, muzzle.rotation);

                Vector3 direction = (bulletDirection) switch
                {
                    Direction.Left => Vector3.left,
                    Direction.Right => Vector3.right,
                    _ => throw new NotImplementedException(),
                };

                muzzle.localPosition = new Vector3(direction.x, 0.5f);

                //bulletToSpawn.SetVelocity(direction);

                _currentTime = 0f;
            }
        }

        private enum Direction { Left, Right }
        */
    }      
