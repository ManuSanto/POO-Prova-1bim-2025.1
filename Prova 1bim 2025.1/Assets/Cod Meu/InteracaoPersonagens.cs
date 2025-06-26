using UnityEngine;

public class InteracaoPersonagens : MonoBehaviour
{
    void OnCollisionEnter(Collision outro)
    {
        if (outro.gameObject.CompareTag("Inimigo"))
        {
            Debug.Log("A Elementalista foi atingida por um inimigo, perdendo 5 de vida.");
            
            GetComponent<Elementalista>().UsarHabilidadeEspecial();
        }
    }
}