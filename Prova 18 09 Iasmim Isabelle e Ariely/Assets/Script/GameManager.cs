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

    private Bloco[,] blocos;

    private int contador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
