using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject explosionPrefab; //prefab dell'animazione della morte
    public float timeDeath; //durata dell'animazione
    private int collisionCount = 0; //quanti proitettili servono per eliminare il nemico

    // Update is called once per frame
    void Update()
    {
        //se il nemico raggiunge la posizione -9.5x si distrugge
        if (transform.position.x <= -9.5f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        // se collide con il game object con tag "bullet" si distrugge
        if (collision.gameObject.CompareTag("Bullet"))
        {
            collisionCount++;

            // Se il contatore delle collisioni raggiunge 4
            if (collisionCount >= 4)
            {
                //GameObject explosionInstance = Instantiate(explosionPrefab, transform.position, transform.rotation);
                Destroy(gameObject);
                GameObject explosionInstance = Instantiate(explosionPrefab, transform.position, transform.rotation);
                Destroy(explosionInstance, timeDeath);
            }
        }
    }
}
