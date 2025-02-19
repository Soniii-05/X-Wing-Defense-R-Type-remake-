using UnityEngine;

public class IntroToWave : MonoBehaviour
{
    public GameObject introScreen; // Riferimento alla schermata introduttiva (Canvas o UI)
    public float displayTime = 3f; // Tempo in secondi in cui la schermata rimane visibile

    void Start()
    {
        // Assicurati che la schermata introduttiva sia visibile all'inizio
        introScreen.SetActive(true);

        // Dopo "displayTime" secondi, nascondi la schermata e inizia il gioco
        Invoke("HideIntroScreen", displayTime);
    }

    // Funzione per nascondere la schermata introduttiva
    void HideIntroScreen()
    {
        introScreen.SetActive(false);
    }
}
