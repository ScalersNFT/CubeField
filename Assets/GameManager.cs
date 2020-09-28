using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    internal void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            SceneManager.LoadScene(0);
        }
    }
    
    internal void WinGame()
    {
        Debug.Log("GameWon");
        SceneManager.LoadScene(2);
    }

}
