using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject explosionPrefab; //prefab dell'animazione della morte
    public float timeDeath; //durata dell'animazione
    private int collisionCount = 0; //numero di inizio conteggio
    public int numberCollision; //quanti proitettili servono per eliminare il nemico

    // Update is called once per frame
    void Update()
    {
        //se il nemico raggiunge la posizione -9.5x si distrugge
        if (transform.position.x <= -9.5f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
         
        // se collide con il game object con tag "bullet" si distrugge
        if (collision.gameObject.CompareTag("Bullet"))
        {
            collisionCount++;

            // se il collisionCount raggiunge 4
            if (collisionCount >= numberCollision)
            {
                //GameObject explosionInstance = Instantiate(explosionPrefab, transform.position, transform.rotation);
                Destroy(gameObject);
                GameObject explosionInstance = Instantiate(explosionPrefab, transform.position, transform.rotation);
                Destroy(explosionInstance, timeDeath);
            }
        }
    }
}
