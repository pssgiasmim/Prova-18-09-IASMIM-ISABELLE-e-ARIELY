using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject blockPrefab;
    [SerializeField] GameObject playerPrefab1;
    [SerializeField] GameObject playerPrefab2;

    public int linha = 5;
    public int coluna = 5;

    public float spacing = 1.1f;

    private Bloco[,] grade;

    private int contador;

    public static GameManager instance;

   
    private void Awake()
    {
        instance = this;

        grade = new GameObject[linha, coluna];

        CriarGrade();
    }

    public void CriarGrade()
    {
        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                Vector2 posicao = new Vector2(i, j);

                GameObject bloco = Instantiate(blockPrefab, posicao, Quaternion.identity);

                grade[i, j] = bloco;

            }
        }

        // Posiciona os jogadores no início do jogo.
        // Calcula a posição inicial do jogador 1.
        // Calcula a posição inicial do jogador 2.

        Camera.main.transform.position = new Vector3(linha / 2f - 0.5f, coluna / 2f - 0.5f, -10);
        Camera.main.orthographicSize = coluna / 2f;

        // Instancia os jogadores nas suas posições iniciais.

    }
}
