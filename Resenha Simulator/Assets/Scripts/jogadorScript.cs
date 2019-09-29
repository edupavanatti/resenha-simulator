using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class jogadorScript : MonoBehaviour {

    public GameObject resenha; // Será preenchido via Inspector com o prefab resenha
    public int speed = 10;
    public int DPs = 0; // Define a quantidade de DPs inicial
    public Text DPsUI; // Cria uma variável para armazenar o número de DPs

    void Update()
    {
        // Move a mão (jogador) horizontalmente com as setas ou as teclas A e D
        float horizontal = Input.GetAxis("Horizontal") * speed *
        Time.deltaTime;

        transform.Translate(horizontal, 0, 0);// Aplicando as mudanças

        // Restringir o movimento da mão ao limite da tela
        if (transform.position.x <= -5.5f || transform.position.x >= 5.5f)
        {
            // Criando o limite
            float xPos = Mathf.Clamp(transform.position.x, -5.5f, 5.5f);
            // Limitando o movimento
            transform.position = new Vector3(xPos, transform.position.y,
            transform.position.z);
        }

        // Quando a barra de espaço é pressionada a resenha é lançada
        if (Input.GetKeyDown("space"))
        {
            // Cria uma nova resenha na posição atual da mão para que ela siga a mão
            Instantiate(resenha, transform.position, Quaternion.identity);
        }        DPsUI.text = "DPS: " + DPs;        // Define o número de DPs que podem ser pegas até terminar o jogo        if (DPs == 3)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
