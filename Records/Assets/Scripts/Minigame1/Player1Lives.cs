using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Para usar TextMeshPro

public class Player1Lives : MonoBehaviour
{
    public int maxLives = 3; // Número máximo de vidas
    private int currentLives; // Vidas atuais
    public TMP_Text livesText; // Referência ao TextMeshPro para mostrar vidas
    private int fallCount = 0; // Contador de quedas
    public GameOverScreen GameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        currentLives = maxLives; // Inicializa as vidas atuais
        UpdateLivesText();
    }

    public void DecreaseLife()
    {
        fallCount++;
        Debug.Log("Quedas: " + fallCount);

        if (fallCount >= 3)
        {
            GameOver();
        }
        else
        {
            currentLives--;
            UpdateLivesText();
            if (currentLives <= 0)
            {
                GameOver();
            }
        }
    }
    // Update is called once per frame
    private void UpdateLivesText()
    {
        if (livesText != null)
        {
            livesText.text = currentLives + " Vidas "; // Atualiza o texto
        }
    }
    private void GameOver()
    {
        Debug.Log("Game Over!");
        // Aqui você pode adicionar lógica para reiniciar o jogo ou mostrar uma tela de Game Over
        // Exemplo:
        Time.timeScale = 0;
        GameOverScreen.ShowGameOver();
        // Pausa o jogo
        // Ou você pode carregar uma nova cena
        // SceneManager.LoadScene("GameOverScene");
    }
}
