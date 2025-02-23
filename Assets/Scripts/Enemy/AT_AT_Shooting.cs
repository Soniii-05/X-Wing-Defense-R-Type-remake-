using UnityEngine;

public class AT_AT_Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;  // prefab del proiettile
    public float spawnInterval = 1f;  // intervallo tra i colpi (in secondi)
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
        // intervallo di spawn tra i proiettili del nemico
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            Shooting();
            timer = 0f;  // Reset del timer
        }
    }

    void Shooting()
    {
        if (bulletPrefab != null && muzzles.Length > 0)
        {
            // Seleziona un punto di sparo casuale dall'array
            Transform randomMuzzle = muzzles[Random.Range(0, muzzles.Length)];

            // Crea il proiettile nella posizione del punto di sparo casuale
            GameObject proiettile = Instantiate(bulletPrefab, randomMuzzle.position, Quaternion.identity);

            // Ottiene il Rigidbody2D del proiettile
            Rigidbody2D rb = proiettile.GetComponent<Rigidbody2D>();

            // Applicare la forza verso sinistra (o qualsiasi direzione desiderata)
            if (rb != null)
            {
                rb.AddForce(Vector2.left * shootForce, ForceMode2D.Impulse);
            }
        }
    }

}
