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
    }
}
