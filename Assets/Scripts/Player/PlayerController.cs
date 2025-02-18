using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed; // velocità del player
    private Rigidbody2D rb; 
    private Vector2 moveDirection;
    private float rotationAngle = 25f;  // gradi di rotazione
    private float originalRotation = 0f; // grado di rotazione originale
    public ShootingMuzzle muzzle; // si riferisce allo script
    public GameObject explosionPrefab; //esplosione da applicare in caso di morte

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  // Ottieni il Rigidbody2D
    }

    
    void Update()
    {
        // ottiene l'input per il movimento orizzontale e verticale
        float moveX = Input.GetAxisRaw("Horizontal");  
        float moveY = Input.GetAxisRaw("Vertical");    
      
        //se premuto E chiama lo script "ShootingMuzzle" e crea il proiettile
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            muzzle.Fire();
        }

        moveDirection = new Vector2(moveX, moveY).normalized;

        if (moveY > 0)  // se la y del player aumenta
        {
            transform.rotation = Quaternion.Euler(0, 0, rotationAngle);  // ruota di n gradi
        } else if (moveY < 0)  // se la y del player diminuisce
        { 
            transform.rotation = Quaternion.Euler(0, 0, -rotationAngle);  // ruota di -n gradi
        } else
        {
            // se non viene premuto nessun tasto, si ripristina la rotazione
            transform.rotation = Quaternion.Euler(0, 0, originalRotation);
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveDirection * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // se collide con il game object con tag "enemy" si distrugge
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameObject explosionInstance = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosionInstance, 0.5f);
            gameObject.SetActive(false);
            SceneManager.LoadScene(5);
        }
    }

}
