using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocit� del personaggio
    private Rigidbody2D rb;
    private Vector2 moveDirection;

    // Start � chiamato una volta quando lo script � attivo
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  // Ottieni il Rigidbody2D
    }

    // Update � chiamato una volta per ogni frame
    void Update()
    {
        // Ottieni l'input dell'utente per il movimento orizzontale e verticale
        float moveX = Input.GetAxisRaw("Horizontal");  // Movimento sinistra-destra (tasti A/D o frecce)
        float moveY = Input.GetAxisRaw("Vertical");    // Movimento su-gi� (tasti W/S o frecce)

        // Definisci la direzione del movimento
        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    // FixedUpdate � usato per la fisica
    void FixedUpdate()
    {
        // Applica la velocit� al Rigidbody2D
        rb.velocity = moveDirection * moveSpeed;
    }
}
