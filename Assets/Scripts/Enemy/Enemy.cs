using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

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
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("hai sconfitto un tie");
            Destroy(gameObject);
            //gameObject.SetActive(false);
        }
    }
}
