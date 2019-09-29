using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alvo1Script : MonoBehaviour {

    private notasScript ntScript; // Para se comunicar com o notasScript
    public AudioClip audioAlvo; // Cria uma variável para adicionar o efeito de áudio

    // Acessa o atributo "notas" do notasScript
    void Start()
    {
        ntScript = GameObject.Find("Notas").GetComponent<notasScript>();
    }

    // Incrementa o atributo "notas" de acordo com a pontuação de cada alvo
    void OnTriggerEnter2D(Collider2D objeto)
    {
        if (objeto.gameObject.tag == "resenhaTag")
        {
            AudioSource.PlayClipAtPoint(audioAlvo, transform.position);
            ntScript.notas += 3;
        }
    }
}
