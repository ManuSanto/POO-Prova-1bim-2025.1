using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    public Personagem inimigo;
    public Elementarista elementarista;

    void Start()
    {
        
        inimigo.AtribuirNome("Inimigo");
        inimigo.AtribuirEnergia(100);
        inimigo.AtribuirForca(80);
        inimigo.AtribuirVelocidade(60f);

        
        elementarista.AtribuirNome("Elementarista");
        elementarista.AtribuirEnergia(120);
        elementarista.AtribuirForca(75);
        elementarista.AtribuirVelocidade(70f);
        elementarista.AtribuirHabilidadeEspecial("Tempestade de Gelo");

        
        Debug.Log("===== Inimigo =====");
        Debug.Log("Nome: " + inimigo.LerNome());
        Debug.Log("Energia: " + inimigo.LerEnergia());
        Debug.Log("Força: " + inimigo.LerForca());
        Debug.Log("Velocidade: " + inimigo.LerVelocidade());

        Debug.Log("===== Elementarista =====");
        Debug.Log("Nome: " + elementarista.LerNome());
        Debug.Log("Energia: " + elementarista.LerEnergia());
        Debug.Log("Força: " + elementarista.LerForca());
        Debug.Log("Velocidade: " + elementarista.LerVelocidade());
        Debug.Log("Habilidade: " + elementarista.LerHabilidadeEspecia());

        
        inimigo.CompararForca(elementarista);

        elementarista.UsarHabilidade();
    }
}
