using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverPanel; // Painel de Game Over (Pop-up)
    public TMP_Text gameOverScoreText; // Texto para mostrar o score no Game Over
    public PlayerMini1 PlayerMini1;


    // Fun��o para ativar o Game Over e exibir a pontua��o
    public void ShowGameOver()
    {
        // Ativa o painel de Game Over
        gameOverPanel.SetActive(true);

        // Exibe o score final no pop-up de Game Over
        gameOverScoreText.text = PlayerMini1.itemCount.ToString() + "pts";
    }

    public void Continuar()
    {
        // Recarrega a cena atual usando o nome dela
        SceneManager.LoadScene("MiniGame 1");
    }

    public void Sair()
    {
        SceneManager.LoadScene("Sala_Fliperama");
    }
}
