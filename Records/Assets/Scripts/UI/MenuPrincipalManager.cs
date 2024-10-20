using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPrincipal : MonoBehaviour
{
    [SerializeField] private string nomeDoLeveldoJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelAjuste;
    public void Jogar()
    {
        SceneManager.LoadScene(nomeDoLeveldoJogo);
    }

    public void AbrirAjustes()
    {
        painelMenuInicial.SetActive(false);
        painelAjuste.SetActive(true);
    }

    public void FecharAjustes()
    {
        painelMenuInicial.SetActive(true);
        painelAjuste.SetActive(false);
    }

    public void Sair()
    {
        Application.Quit();
        Debug.Log("Sai do jogo!!");
    }
}
