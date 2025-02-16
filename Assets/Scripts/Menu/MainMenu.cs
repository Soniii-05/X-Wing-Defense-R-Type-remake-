using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{  
    public void PlayGame()
    {
        SceneManager.LoadScene(2); //change the scene number
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void HowToPlayMenu()
    {
        SceneManager.LoadScene(1);
    }



}
