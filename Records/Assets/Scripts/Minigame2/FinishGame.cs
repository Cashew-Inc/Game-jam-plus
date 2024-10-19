using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public GameObject winCanvas;
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
    }

    public bool getHasWon()
    {
        return hasWon;
    }
}
