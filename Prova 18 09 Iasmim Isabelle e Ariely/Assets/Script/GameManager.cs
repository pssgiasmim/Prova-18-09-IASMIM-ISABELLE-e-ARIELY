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

    private int contador = 0;

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

        Vector3 posicaoJogador1 = new Vector3(0, 0.5f, 0);
        Vector3 posicaoJogador2 = new Vector3((linha - 1 ) * 1.1f, 0.5f, (coluna - 1) * 1.1f);

        Camera.main.transform.position = new Vector3(linha / 2f - 0.5f, coluna / 2f - 0.5f, -10);
        Camera.main.orthographicSize = coluna / 2f;

        Instantiate(playerPrefab1, posicaoJogador1, Quaternion.identity);
        Instantiate(playerPrefab2, posicaoJogador2, Quaternion.identity);
        

    }

    public void ConquistarTerritorio()
    {
        contador++;


        if (contador =grade)
        {
            int contadorDeTerritorioDoJogador1 = 0;
            int contadorDeTerritorioDoJogador2 = 0;

            for (int i = 0; i < linha; i++) 
            {
                for (int j = 0; j < coluna; j++)
                {
                    Bloco bloco = grade[i, j].GetComponent<Bloco>();

                    if (bloco.dono == 1)
                    {
                        contadorDeTerritorioDoJogador1++;

                    }
                    else if (bloco.dono == 2)
                    {
                        contadorDeTerritorioDoJogador2++;
                    }
                }
            }
        }
    }

    private void FimDeJogo()
    {
        
    }
}
