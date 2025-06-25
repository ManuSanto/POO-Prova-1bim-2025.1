using UnityEngine;

public class PersonagemGen : MonoBehaviour
{
    [SerializeField]
    private string nome;
    [SerializeField]
    private int energia;
    [SerializeField]
    private int forcaAtaque;
    [SerializeField]
    private float forcaDoPulo;
    [SerializeField]
    private float velocidade;


    public void SetNome(string novoNome)
    {
        nome = novoNome;
    }
    public string GetNome()
    {
        return nome;
    }

    public void SetEnergia(int novaEnergia)
    {
        energia = novaEnergia;
    }
    public int GetEnergia()
    {
        return energia;
    }

    public void SetForcaAtaque(int novaForca)
    {
        forcaAtaque = novaForca;
    }
    public int GetForcaAtaque()
    {
        return forcaAtaque;
    }

    public void SetForcaDoPulo(float novaForcaDoPulo)
    {
        forcaDoPulo = novaForcaDoPulo;
    }
    public float GetForcaDoPulo()
    {
        return forcaDoPulo;
    }

    public void SetVelocidade(float novaVelocidade)
    {
        velocidade = novaVelocidade;
    }
    public float GetVelocidade()
    {
        return velocidade;
    }

    public bool CompararEnergia(PersonagemGen outroPersonagem)
    {
        return this.energia == outroPersonagem.energia;
    }
}
