using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public GameObject winCanvas;
    public AudioSource winAudioSource;  // Refer�ncia ao AudioSource
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
        if (winAudioSource != null)  // Certifique-se de que h� um AudioSource configurado
        {
            winAudioSource.Play();  // Toca o �udio ao ganhar o jogo
        }
    }

    public bool getHasWon()
    {
        return hasWon;
    }
}
