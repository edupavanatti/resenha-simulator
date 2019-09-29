using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo2Script : MonoBehaviour {

    private jogadorScript DPScript; // Para se comunicar com o jogadorScript
    public int speed; // Define a velocidade com que a barreira se move
    public float length; // Define o alcance do movimento da barreira
    private float counter; // Utilizado pela função Mathf
    private float inicio; // Define a posição de início da barreira
    public AudioClip audioObstaculo; // Adicionar o audio para a colisão com as barreiras

    // Acessa o atributo "Jogador" do jogadorScript
    void Start()
    {
        DPScript = GameObject.Find("Jogador").GetComponent<jogadorScript>();
        inicio = transform.position.x;
    }

    // Define a movimentação da barreira
    void Update()
    {
        // Move o obstáculo pela tela
        float horizontal = speed * Time.deltaTime;
        counter += horizontal;
        transform.position = new Vector2(Mathf.PingPong(counter, length) - inicio, transform.position.y);

        // Restringir o movimento do obstáculo ao limite da tela
        if (transform.position.x <= -5.5f || transform.position.x >= 5.5f)
        {
            // Criando o limite
            float xPos = Mathf.Clamp(transform.position.x, -5.5f, 5.5f);
            // Limitando o movimento
            transform.position = new Vector3(xPos, transform.position.y,
            transform.position.z);
        }
    }

    // Define o que acontece quando a resenha toca na barreira
    void OnTriggerEnter2D(Collider2D objeto)
    {
        if (objeto.gameObject.tag == "resenhaTag")
        {
            AudioSource.PlayClipAtPoint(audioObstaculo, transform.position);
            DPScript.DPs++; // Cada colisao ganha uma DP
        }

    }
}
