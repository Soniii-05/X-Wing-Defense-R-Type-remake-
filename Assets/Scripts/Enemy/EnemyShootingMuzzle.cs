using UnityEngine;

public class EnemyShootingMuzzle : MonoBehaviour
{

    public GameObject bulletPrefab;  // prefab del proiettile
    public float spawnInterval = 1f;  // intervallo tra i colpi (in secondi)
    private float timer = 0f;
    public float shootForce = 10f;      // forza di sparo del proiettile


    void Start()
    {
        // chiama il metodo dello spawn di proiettili
        Shooting();
    }

    void Update()
    {
        // intervallo di spawn tra i proiettili del nemico
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            Shooting();
            timer = 0f;  // reset del timer
        }
    }

    void Shooting()
    {
        if (bulletPrefab != null)
        {
            // crea il proiettile all'interno della posizione del nemico
            GameObject proiettile = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Rigidbody2D rb = proiettile.GetComponent<Rigidbody2D>();

            // applica una forza verso sinistra
            if (rb != null)
            {
                rb.AddForce(Vector2.left * shootForce, ForceMode2D.Impulse);
            }
        }
    }

}
