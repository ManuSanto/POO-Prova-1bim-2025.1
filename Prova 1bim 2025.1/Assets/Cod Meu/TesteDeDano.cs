using System;
using UnityEngine;

public class TesteDeDano : MonoBehaviour
{
    private Personagem personagem;
    
    private void OnCollisionEnter(Collision colisao)
    {
        if (colisao.gameObject.CompareTag("Inimigo"))
        {
            
           
            Debug.Log("O personagem " +personagem.Nome()+" tem agora "+personagem.Energia());
        }
    }
    
}