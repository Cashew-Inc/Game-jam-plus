using UnityEngine;
public class GameOver : MonoBehaviour
{
    public GameObject loseCanvas;
    private bool isGameOver = false;
    private FinishGame finishGameScript;
    void Start()
    {
        loseCanvas.SetActive(false);
        finishGameScript = FindObjectOfType<FinishGame>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Stone") && !isGameOver)
        {
            TriggerGameOver();
        }
    }

    void TriggerGameOver()
    {
        isGameOver = true;
        if (!finishGameScript.getHasWon())
        {
            loseCanvas.SetActive(true);
        }
        Time.timeScale = 0;
    }
}
