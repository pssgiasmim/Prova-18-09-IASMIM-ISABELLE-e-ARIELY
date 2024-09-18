using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;

public class Bloco : MonoBehaviour
{

    private bool conquistado = false;
    private SpriteRenderer spriteRenderer;
    private int jogadorDono;

    private void Awake()
    {
       spriteRenderer = GetComponent<SpriteRenderer>(); //verificar se falta GameObject

        spriteRenderer.color = Color.white; // Verificar se é preciso utilizar método auxiliar que será criado      
    }

    public void AlterarConquista(bool jogador1, Color corDoJogador)
    {
        conquistado = true;
        Awake(); 
        spriteRenderer.color = new Color(); //Rever chamada do método Awake

        if (jogador1 == true )
        {
          bool jogadorDono = true; // rever
            
            // notificar Game Manager
        }
        else  
        {
           // bool jogadorDono = true; 
           //notificar Game Manager
        }
    }
}
