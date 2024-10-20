using UnityEngine;
using UnityEngine.SceneManagement;  // Para carregar a cena

public class Menu : MonoBehaviour
{
    public Canvas menuCanvas;
    private bool isMenuOpen = false;

    void Start()
    {
        menuCanvas.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isMenuOpen = !isMenuOpen;
            menuCanvas.enabled = isMenuOpen;

            // Pausar o jogo ao abrir o menu
            Time.timeScale = isMenuOpen ? 0 : 1;
        }
    }

    // Função para fechar o jogo
    public void QuitGame()
    {
        Debug.Log("Fechando o jogo...");
        Application.Quit();
    }

    // Função para voltar ao menu principal
    public void GoToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    // Função para fechar o menu e continuar o jogo
    public void CloseMenu()
    {
        isMenuOpen = false;
        menuCanvas.enabled = false;
        Time.timeScale = 1;
    }
}
