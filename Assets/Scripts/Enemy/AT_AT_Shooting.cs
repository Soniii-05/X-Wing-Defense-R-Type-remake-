using UnityEngine;

public class AT_AT_Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;  // prefab del proiettile
    public float spawnInterval = 1f;  // intervallo tra i colpi
    private float timer = 0f;
    public float shootForce = 10f;      // forza di sparo del proiettile
    public Transform[] muzzles;  // array di punti di sparo ("muzzle")

    void Start()
    {
        // chiama il metodo dello spawn di proiettili
        Shooting();
    }

    void Update()
    {
        // intervallo di spawn tra i proiettili
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            Shooting();
            timer = 0f;  // reset del timer
        }
    }

    void Shooting()
    {
        if (bulletPrefab != null && muzzles.Length > 0)
        {
            // seleziona uno shooting muzzle casuale dall'array
            Transform randomMuzzle = muzzles[Random.Range(0, muzzles.Length)];
            GameObject projectile = Instantiate(bulletPrefab, randomMuzzle.position, Quaternion.identity);           
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            // applica la forza verso sinistra
            if (rb != null)
            {
                rb.AddForce(Vector2.left * shootForce, ForceMode2D.Impulse);
            }
        }
    }

}
