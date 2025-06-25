using UnityEngine;


public class Elementarista : Personagem
{
    [Header("Habilidade Especial")]
    public string habilidadeEspecial = "Tempestade de Gelo";
    
    public void AtribuirHabilidadeEspecial(string novaHabilidade)
    {
        this.habilidadeEspecial = novaHabilidade;
    }
   
    public string LerHabilidadeEspecial()
    {
        return this.habilidadeEspecial;
    }
    
    public void UsarHabilidade()
    {
        Debug.Log(nome + " usou a habilidade: " + habilidadeEspecial);
    }
}