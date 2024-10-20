using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    public GameObject tutorialCanvas;
    // Start is called before the first frame update
    void Start()
    {
        // Ativar o Canvas do tutorial e pausar o jogo ao iniciar a cena
        tutorialCanvas.SetActive(true);
        Time.timeScale = 0f;  // Pausa o tempo
    }

    // Função chamada quando clicar no botão "Jogar"
    public void PlayGame()
    {
        // Desativar o Canvas do tutorial e despausar o tempo
        tutorialCanvas.SetActive(false);
        Time.timeScale = 1f;  // Despausa o tempo
    }
}
