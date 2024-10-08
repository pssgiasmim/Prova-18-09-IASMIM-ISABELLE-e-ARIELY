using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;

public class Bloco : MonoBehaviour
{

    private bool conquistado = false;
    private SpriteRenderer spriteRenderer;
    private int jogadorDono = 0;

    private void Awake()
    {
       spriteRenderer = GetComponent<SpriteRenderer>(); 

        spriteRenderer.color = Color.white;      
    }

    public void AlterarConquista(bool jogador1, Color corDoJogador)
    {
        conquistado = true;
        
        spriteRenderer.color = new Color(); 

        if (jogador1)
        {
          jogadorDono = 1;

            GameManager.instance.ConquistarTerritorio(); 
        }
        else  
        {
            jogadorDono = 2;
            GameManager.instance.ConquistarTerritorio();
        }
    }

    public bool PegarConquistado()
    {
        return conquistado = true && !conquistado;
           
    }

    public int PegarJogadorDono()
    {
        if (jogadorDono == 1) ;
        {
            return 1;
        }

        else
        {
            return 2;
        }
    }
    private void AtualizarCor(Color novaCor)
    { 
        spriteRenderer.color = novaCor;
    }
}
