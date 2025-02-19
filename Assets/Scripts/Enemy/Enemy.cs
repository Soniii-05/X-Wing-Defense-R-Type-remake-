using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject explosionPrefab; // prefab dell'animazione della morte
    public float timeDeath; // durata dell'animazione
    private int collisionCount = 0; // numero di inizio conteggio
    public int numberCollision; // quanti proiettili servono per eliminare il nemico

    public int points; // punti da aggiungere al punteggio quando il nemico viene distrutto
    private ScoreManager scoreManager; // riferimento al ScoreManager

    
    void Start()
    {
        // trova il ScoreManager nella scena
        //scoreManager = FindObjectOfType<ScoreManager>();
        scoreManager = Object.FindFirstObjectByType<ScoreManager>();
    }
    
    
    void Update()
    {
        //  se il nemico raggiunge la posizione -9.5x, si distrugge
        if (transform.position.x <= -9.5f)
        {
            Destroy(gameObject);
        }
    }

        // rileva la collisione con il bullet
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // se collide con il GameObject con tag "Bullet"
        if (collision.gameObject.CompareTag("Bullet"))
        {
            collisionCount++;

            // se il collisionCount raggiunge il numero delle collisioni necessarie
            if (collisionCount >= numberCollision)
            {
                // aggiunge i punti al punteggio
                if (scoreManager != null)
                {
                    scoreManager.AddScore(points);
                }

                //crea l'esplosione e il nemico si distrugge
                GameObject explosionInstance = Instantiate(explosionPrefab, transform.position, transform.rotation);
                Destroy(explosionInstance, timeDeath);
                Destroy(gameObject);
            }
        }
    }
}
