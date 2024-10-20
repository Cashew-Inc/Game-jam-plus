using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public GameObject winCanvas;
    public AudioSource winAudioSource;
    public AudioSource backgroundAudioSource;
    private bool hasWon = false;
    public GameOverHUD GameOverHUD;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasWon)
        {
            winGame();
        }
    }

    public void winGame()
    {
        hasWon = true;
        GameOverHUD.ShowGameOver();


        // Parar o áudio de fundo
        if (backgroundAudioSource != null && backgroundAudioSource.isPlaying)
        {
            backgroundAudioSource.Stop();  // Para o áudio de fundo
        }

        // Tocar o áudio de vitória
        if (winAudioSource != null)
        {
            winAudioSource.Play();  // Toca o áudio de vitória
        }
    }

    public bool getHasWon()
    {
        return hasWon;
    }
}
