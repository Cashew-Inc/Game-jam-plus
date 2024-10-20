using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public GameObject winCanvas;
    public AudioSource winAudioSource;
    public AudioSource backgroundAudioSource;
    private bool hasWon = false;

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
        winCanvas.SetActive(true);

        // Parar o �udio de fundo
        if (backgroundAudioSource != null && backgroundAudioSource.isPlaying)
        {
            backgroundAudioSource.Stop();  // Para o �udio de fundo
        }

        // Tocar o �udio de vit�ria
        if (winAudioSource != null)
        {
            winAudioSource.Play();  // Toca o �udio de vit�ria
        }
    }

    public bool getHasWon()
    {
        return hasWon;
    }
}
