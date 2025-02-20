using UnityEngine;

public class EnemyShootingMuzzle : MonoBehaviour
{
    public GameObject bullet; // prefab del proiettile
    public Transform[] muzzle; // posizione in cui lo crea
    public float bulletForce; // forza del proiettile quando sparato
    private int currentMuzzleIndex = 0; // index iniziale per il ciclo

    public void Fire()
    {
        // crea il proiettile nella posizione "muzzle" con la sua rotazione e posizione
        GameObject projectile = Instantiate(bullet, muzzle[currentMuzzleIndex].position, muzzle[currentMuzzleIndex].rotation);

        // aggiungi un impulso verso sinistra
        Vector2 direction = -muzzle[currentMuzzleIndex].right; // usa il vettore "right" invertito per andare verso sinistra
        projectile.GetComponent<Rigidbody2D>().AddForce(direction * bulletForce, ForceMode2D.Impulse);

        // incrementa l'index del muzzle
        currentMuzzleIndex = (currentMuzzleIndex + 1) % muzzle.Length;
    }
}
