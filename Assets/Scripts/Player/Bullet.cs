using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    //public Rigidbody2D rb;

    internal void SetVelocity(Vector3 direction)
    {
        throw new NotImplementedException();
    }

    public void Update() 
    {
        //se i proiettili arrivano alla posizione 9.10 dell'asse x si distruggono
        if (transform.position.x >= 9.10f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // se collide con il game object con tag "bullet" si distrugge
        if (collision.gameObject.CompareTag("Enemy"))
        {
            
            Destroy(gameObject);
            
        }
    }
}
