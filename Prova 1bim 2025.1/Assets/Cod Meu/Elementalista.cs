using UnityEngine;

public class Elementalista : Personagem
{
    public string habilidade = "Tempestade de Gelo";

    public void UsarHabilidadeEspecial()
    {
        Debug.Log(nome + " usou a habilidade " + habilidade);
    }
}