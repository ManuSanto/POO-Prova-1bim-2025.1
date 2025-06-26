using UnityEngine;

using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    public Personagem elementalista;
    public Personagem inimigo;

    void Start()
    {
        elementalista.AtribuirNome("Elementalista");
        elementalista.AtribuirForça(100);
        elementalista.AtribuirAtaque(25);
        elementalista.AtribuirVelocidade(5.5f);

        inimigo.AtribuirNome("Inimigo");
        inimigo.AtribuirForça(80);
        inimigo.AtribuirAtaque(15);
        inimigo.AtribuirVelocidade(4f);

        Debug.Log("Personagem: " + elementalista.nome);
        Debug.Log("Força: " + elementalista.força);
        Debug.Log("Ataque: " + elementalista.ataque);
        Debug.Log("Velocidade: " + elementalista.velocidade);

        elementalista.CompararCom(inimigo);
    }
}
