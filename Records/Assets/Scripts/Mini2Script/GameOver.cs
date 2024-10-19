using UnityEngine;
using UnityEngine.SceneManagement; 
public class GameOver : MonoBehaviour
{
    public string gameOverSceneName;
    private bool isGameOver = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("dsofgoaiugo");
        if (collision.gameObject.CompareTag("Stone") && !isGameOver)
        {
            TriggerGameOver();
        }
    }

    void TriggerGameOver()
    {
        isGameOver = true;
        SceneManager.LoadScene(gameOverSceneName);
    }
}
