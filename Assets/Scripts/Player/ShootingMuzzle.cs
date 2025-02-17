using UnityEngine;

public class ShootingMuzzle : MonoBehaviour
{
    public GameObject bullet; // prefab del proiettile
    public Transform[] muzzle; // posizione in cui lo crea
    public float bulletForce; // forza del proiettile quando sparato
    private int currentMuzzleIndex = 0; // index iniziale per il ciclo

    public void Fire()
    {
        // crea il proiettile nella posizione "muzzle" con la sua rotazione e posizione, ottiene il rigid body e ci aggiunge un impulso verso destra
        GameObject projectile = Instantiate(bullet, muzzle[currentMuzzleIndex].position, muzzle[currentMuzzleIndex].rotation);
        projectile.GetComponent<Rigidbody2D>().AddForce(muzzle[currentMuzzleIndex].right * bulletForce, ForceMode2D.Impulse);

        // incrementa l'index del muzzle
        currentMuzzleIndex = (currentMuzzleIndex + 1) % muzzle.Length; 
    }
}
