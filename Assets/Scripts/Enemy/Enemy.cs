using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject explosionPrefab;

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
            GameObject explosionInstance = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(explosionInstance, 0.5f);
        }
    }
}
