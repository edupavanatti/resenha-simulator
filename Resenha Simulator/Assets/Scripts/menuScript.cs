using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Define os botões a serem utilizados no Menu
public class menuScript : MonoBehaviour
{

    public Button newGameButton;
    public Button exitGameButton;

    // Define as funções de clique dos botões ao abrir o Menu
    public void Awake()
    {
        newGameButton.onClick.AddListener(NewGame);
        exitGameButton.onClick.AddListener(ExitGame);
    }

    // Ao clicar no botão começa uma nova partida
    public void NewGame()
    {
        SceneManager.LoadScene("Jogo");
    }

    // Ao clicar no botão sai do jogo
    public void ExitGame()
    {
        Application.Quit();
    }

}