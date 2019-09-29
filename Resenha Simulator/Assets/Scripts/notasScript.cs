using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class notasScript : MonoBehaviour {

    public Text notasUI; // Cria uma variável para armazenas as notas (pontuação)
    public Text recordeUI; // Cria uma variável que mostra a nota mais alta obtida pelo jogador
    public int notas = 0; // Define o valor inicial da nota final

    // Armazena a pontuação (nota) mais alta obtida pelo jogador e mostra as notas na tela
    void Update()
    {
        if (notas > PlayerPrefs.GetInt("Recorde"))
        {
            PlayerPrefs.SetInt("Recorde", notas);
        }
        notasUI.text = "NOTA FINAL: " + notas;
        recordeUI.text = "NOTA MAIS ALTA: " + PlayerPrefs.GetInt("Recorde");
    }
}
