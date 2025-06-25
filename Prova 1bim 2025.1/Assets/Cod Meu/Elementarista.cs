using UnityEngine;

public class Elementalista : PersonagemGen
{
    [SerializeField]
    private string elementoPrincipal;
    [SerializeField]
    private int poderMagico;


    public void SetElementoPrincipal(string novoElemento)
    {
        elementoPrincipal = novoElemento;
    }

    public string GetElementoPrincipal()
    {
        return elementoPrincipal;
    }

    public void SetPoderMagico(int novoPoder)
    {
        poderMagico = novoPoder;
    }

    public int GetPoderMagico()
    {
        return poderMagico;
    }

    public void LançarFeitiço()
    {
        Debug.Log($"{GetNome()} lançou um feitiço de {elementoPrincipal} com poder {poderMagico}!");
    }
}