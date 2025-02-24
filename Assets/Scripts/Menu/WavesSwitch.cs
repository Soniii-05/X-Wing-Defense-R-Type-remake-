using UnityEngine;
using UnityEngine.SceneManagement;

public class WavesSwitch : MonoBehaviour
{
   public void firstWave()
   {
        SceneManager.LoadScene(2);
   }
    
    public void secondWave()
   {
        SceneManager.LoadScene(3);
   }
    
    public void thirdWave()
   {
        SceneManager.LoadScene(4);
   }
    
    public void fourthWave()
   {
        SceneManager.LoadScene(5);
   }
}
