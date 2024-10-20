using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class GameOverHUD : MonoBehaviour
{
    public GameObject gameOverPanel; // Painel de Game Over (Pop-up)
    public TMP_Text gameOverScoreText; // Texto para mostrar o score no Game Over

    private FinishGame finishGameScript;

    void Start()
    {
        finishGameScript = FindObjectOfType<FinishGame>();
    }
    // Função para ativar o Game Over e exibir a pontuação
    public void ShowGameOver()
    {
        // Ativa o painel de Game Over
        gameOverPanel.SetActive(true);

        // Exibe o score final no pop-up de Game Over
        if (!finishGameScript.getHasWon())
        {
            gameOverScoreText.text =  "Perdeu";
        }
        else
        {
            gameOverScoreText.text = "Ganhou";
        }
    }

    public void Continuar()
    {
        // Recarrega a cena atual usando o nome dela
        SceneManager.LoadScene("MiniGame 2", LoadSceneMode.Single);
        Time.timeScale = 1;
    }

    public void Sair()
    {
        SceneManager.LoadScene("Sala_Fliperama", LoadSceneMode.Single);
        Time.timeScale = 1;

    }
}
