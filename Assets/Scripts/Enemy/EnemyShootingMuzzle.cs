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
            timer = 0f;  // Reset del timer
        }
    }

    void Shooting()
    {
        if (bulletPrefab != null)
        {
            // crea il proiettile all'interno della posizione del nemico
            GameObject proiettile = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            // ottiene il Rigidbody2D del proiettile
            Rigidbody2D rb = proiettile.GetComponent<Rigidbody2D>();

            // applica una forza verso sinistra
            if (rb != null)
            {
                rb.AddForce(Vector2.left * shootForce, ForceMode2D.Impulse);
            }
        }
    }
    /*
    public GameObject bullet; // prefab del proiettile
    public Transform[] muzzle; // posizione in cui lo crea
    public float bulletForce; // forza del proiettile quando sparato
    private int currentMuzzleIndex = 0; // index iniziale per il ciclo

    public void Update()
    {
        // crea il proiettile nella posizione "muzzle" con la sua rotazione e posizione
        GameObject projectile = Instantiate(bullet, muzzle[currentMuzzleIndex].position, muzzle[currentMuzzleIndex].rotation);

        // aggiungi un impulso verso sinistra
        Vector2 direction = -muzzle[currentMuzzleIndex].right; // usa il vettore "right" invertito per andare verso sinistra
        projectile.GetComponent<Rigidbody2D>().AddForce(direction * bulletForce, ForceMode2D.Impulse);

        // incrementa l'index del muzzle
        currentMuzzleIndex = (currentMuzzleIndex + 1) % muzzle.Length;

    }
    */
}
