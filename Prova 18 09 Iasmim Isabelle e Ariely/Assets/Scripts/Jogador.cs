using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class Jogador : MonoBehaviour
{
    private const float velocidade = 5f;
    [SerializeField] private bool jogador1;
    [SerializeField] private Color corDoJogador;
    private Vector2 direcao;

    private void Update()
    {
        if (jogador1)
        {
            if (Input.GetKey(KeyCode.A))
                direcao.x = -1;
            else if (Input.GetKey(KeyCode.D))
            direcao.x = 1;
            else direcao.x = 0;

            if (Input.GetKey(KeyCode.W))
                direcao.y = 1;
            else if (Input.GetKey(KeyCode.W))
                direcao.y = 1;
            else
                direcao.y = 0;
        }
        else
        {
            if (Input.GetKey(KeyCode.LeftArrow))
                direcao.x = -1;
            else if (Input.GetKey(KeyCode.RightArrow))
                direcao.x = 1;
            else
                direcao.x = 0;

            if (Input.GetKey(KeyCode.DownArrow))
                direcao.y = -1;
            else if (Input.GetKey(KeyCode.UpArrow))
                direcao.y = 1;
            else
                direcao.y = 0;
        }
        transform.Translate(direcao * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Block"))
        {
            Bloco bloco = other.GetComponent<Bloco>();

            if (!bloco.PegarConquista)
            {
                bloco.AlterarConquista(jogador1, corDoJogador);
            }
        }
    }
}
    