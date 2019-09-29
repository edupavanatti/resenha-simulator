using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resenhaScript : MonoBehaviour {

    public float speed;
    // Usado para definir a velocidade quando a resenha é lançada

    void Start()
    {
        // Ajusta a velocidade para fazer a resenha se mover em direção a lousa
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
    }

    // Quando a resenha ficar invisível ela será destruída
    void OnBecameInvisible()
    {
        // Destroi a resenha quando ela já está fora da tela
        Destroy(gameObject);
    }

    // Destroi a resenha quando ela toca em um alvo ou uma barreira
    void OnTriggerEnter2D(Collider2D objeto)
    {
        if (objeto.gameObject.tag == "obstaculoTag" || objeto.gameObject.tag == "alvoTag")
        {
            Destroy(this.gameObject);
        }
    }

}
