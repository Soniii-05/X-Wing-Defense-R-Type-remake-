using UnityEngine;

public class IntroToWave : MonoBehaviour
{
    public GameObject introScreen; // UI della schermata
    public float displayTime = 3f; // tempo in secondi in cui la schermata rimane visibile

    void Start()
    {
        
        introScreen.SetActive(true);

        // dopo "displayTime" secondi, nasconde la schermata e inizia il gioco
        Invoke("HideIntroScreen", displayTime);
    }

    // funzione per nascondere la schermata di inizio wave
    void HideIntroScreen()
    {
        introScreen.SetActive(false);
    }
}
