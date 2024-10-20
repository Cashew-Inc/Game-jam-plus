using UnityEngine;
public class GameOver : MonoBehaviour
{
    public GameObject loseCanvas;
    private bool isGameOver = false;
    private FinishGame finishGameScript;
    public AudioSource loseAudioSource;
    public AudioSource backgroundAudioSource;
    public GameOverHUD GameOverHUD;
    void Start()
    {
        loseCanvas.SetActive(false);
        finishGameScript = FindObjectOfType<FinishGame>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Stone") && !isGameOver)
        {
            if (backgroundAudioSource != null && backgroundAudioSource.isPlaying)
            {
                backgroundAudioSource.Stop();
            }
            TriggerGameOver();
        }
    }

    void TriggerGameOver()
    {
        isGameOver = true;
        if (!finishGameScript.getHasWon())
        {
            GameOverHUD.ShowGameOver();

        }
        loseAudioSource.Play();
        Time.timeScale = 0;
    }
}
