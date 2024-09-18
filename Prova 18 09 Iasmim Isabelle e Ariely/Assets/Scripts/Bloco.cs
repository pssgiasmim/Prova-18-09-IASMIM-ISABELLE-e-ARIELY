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

            GameManager.NotificarConquista(1); // notificar Game Manager
        }
        else  
        {
            jogadorDono = 2;
            GameManager.NotificarConquista(2);//notificar Game Manager
        }
    }

    public bool PegarConquistado(int jogadorDono)
    {
        if (conquistado == true)
        {
            return true;
        }
        else
        {
            return false;
        }
           
    }

    public int PegarJogadorDono(int jogador1 = 1, bool jogadorDono)
    {
        if (jogadorDono == true)
        {
            return jogador1;
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
