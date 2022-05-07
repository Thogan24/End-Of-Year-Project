using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool playerDead = false;

    public float deathScreenDelay = 2f;
    public void Death() // You can call this in other classes by using gameManager.Death();
    {
        playerDead = true;
        Debug.Log("PLAYER IS DEAD");
        Invoke("changeToDeathScene", deathScreenDelay);

    }

    public void changeToDeathScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
