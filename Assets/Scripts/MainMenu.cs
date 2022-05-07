using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    

    public void StartGame()
    {
        // Changes the scene to the game
        Debug.Log("Start");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        // Quits game
        Debug.Log("Quit");
        Application.Quit();
    }
}
