using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
}
