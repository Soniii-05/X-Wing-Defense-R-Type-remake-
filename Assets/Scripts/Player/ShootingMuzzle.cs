using UnityEngine;

public class ShootingMuzzle : MonoBehaviour
{
    public GameObject bullet; //cosa crea
    public Transform[] muzzle; //dove lo crea
    public float bulletForce;
    private int currentMuzzleIndex = 0; //indice iniziale

    public void Fire()
    {
        // Crea il proiettile nella posizione e rotazione del muzzle corrente
        GameObject projectile = Instantiate(bullet, muzzle[currentMuzzleIndex].position, muzzle[currentMuzzleIndex].rotation);
        projectile.GetComponent<Rigidbody2D>().AddForce(muzzle[currentMuzzleIndex].right * bulletForce, ForceMode2D.Impulse);

        // Incrementa l'indice del muzzle
        currentMuzzleIndex = (currentMuzzleIndex + 1) % muzzle.Length; // Cicla attraverso gli indici
    }

    /*
    public GameObject bullet; //cosa crea
    public Transform muzzle; //dove lo crea
    public Transform muzzle2;

    public float bulletForce;
    public void Fire()
    {
        //crea il proiettile nella posizione e rotazione del muzzle
        GameObject projectile = Instantiate(bullet, muzzle.position, muzzle.rotation);
        projectile.GetComponent<Rigidbody2D>().AddForce(muzzle.right * bulletForce, ForceMode2D.Impulse);
        
        GameObject projectile1 = Instantiate(bullet, muzzle2.position, muzzle2.rotation);
        projectile.GetComponent<Rigidbody2D>().AddForce(muzzle2.right * bulletForce, ForceMode2D.Impulse);
    }
    */
}
