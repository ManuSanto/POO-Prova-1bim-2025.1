using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField] private string nome;
    [SerializeField] private int energia;
    [SerializeField] private int forca;
    [SerializeField] private float velocidade;

    

    public void AtribuirNome(string novoNome)
    {
        this.nome = novoNome;
    }

    public void AtribuirEnergia(int novaEnergia)
    {
        this.energia = novaEnergia;
    }

    public void AtribuirForca(int novaForca)
    {
        this.forca = novaForca;
    }

    public void AtribuirVelocidade(float novaVelocidade)
    {
        this.velocidade = novaVelocidade;
    }

    
    public string LerNome()
    {
        return this.nome;
    }

    public int LerEnergia()
    {
        return this.energia;
    }

    public int LerForca()
    {
        return this.forca;
    }

    public float LerVelocidade()
    {
        return this.velocidade;
    }
    

    public void CompararForca(Personagem outro)
    {
        if (this.forca > outro.forca)
        {
            Debug.Log(nome + " é mais forte que " + outro.nome);
        }
        else if (this.forca < outro.forca)
        {
            Debug.Log(outro.nome + " é mais forte que " + nome);
        }
        else
        {
            Debug.Log(nome + " e " + outro.nome + " têm a mesma força.");
        }
    }
}