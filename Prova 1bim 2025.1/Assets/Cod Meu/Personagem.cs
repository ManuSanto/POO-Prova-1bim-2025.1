using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string nome;
    public int força;
    public int ataque;
    public float velocidade;

    public void AtribuirNome(string novoNome)
    {
        nome = novoNome;
    }

    public void AtribuirForça(int novaForca)
    {
        força = novaForca;
    }

    public void AtribuirAtaque(int novoAtaque)
    {
        ataque = novoAtaque;
    }

    public void AtribuirVelocidade(float novaVelocidade)
    {
        velocidade = novaVelocidade;
    }

    public void CompararCom(Personagem outro)
    {
        if (this.força > outro.força)
        {
            Debug.Log(nome + " tem mais força que " + outro.nome);
        }
        else if (this.força < outro.força)
        {
            Debug.Log(outro.nome + " tem mais força que " + nome);
        }
        else
        {
            Debug.Log(nome + " e " + outro.nome + " têm a mesma força");
        }
    }

    public void UsarHabilidadeEspecial()
    {
        throw new System.NotImplementedException();
    }
}