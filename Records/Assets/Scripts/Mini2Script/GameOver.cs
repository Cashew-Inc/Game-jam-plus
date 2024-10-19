using UnityEngine;
public class GameOver : MonoBehaviour
{
    public GameObject loseCanvas;
    private bool isGameOver = false;
    void Start()
    {
        loseCanvas.SetActive(false);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Stone") && !isGameOver)
        {
            TriggerGameOver();
        }
    }

    void TriggerGameOver()
    {
        isGameOver = true;
        loseCanvas.SetActive(true);
        Time.timeScale = 0;
    }
}
