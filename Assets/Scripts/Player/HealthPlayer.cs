using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{
    public int health = 1000;  // salute iniziale (massima)
    public TMP_Text healthText;
    public GameObject explosionPrefab; //esplosione da applicare in caso di morte


    void Start()
    {
        UpdateHealthText();
    }

    
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0) health = 0;  // non accetta una salute negativa 
        UpdateHealthText();

        // se la salute arriva a 0, carica la scena gameover
        if (health == 0)
        {
            GameObject explosionInstance = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosionInstance, 0.5f);
            gameObject.SetActive(false);
            SceneManager.LoadScene(7);
        }
    }

    // aggiorna il testo UI della salute
    void UpdateHealthText()
    {
        healthText.text = "HP: " + health.ToString();
    }

}
