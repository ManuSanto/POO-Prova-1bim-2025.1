using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    void Start()
    {
        PersonagemGen personagem = new GameObject("PersonagemGen").AddComponent<PersonagemGen>();
        personagem.SetNome("Arqueiro");
        personagem.SetEnergia(100);
        personagem.SetForcaAtaque(30);
        personagem.SetForcaDoPulo(2.5f);
        personagem.SetVelocidade(6.0f);

        Debug.Log($"Personagem Genérico: {personagem.GetNome()}, Energia: {personagem.GetEnergia()}, Força de Ataque: {personagem.GetForcaAtaque()}, Força do Pulo: {personagem.GetForcaDoPulo()}, Velocidade: {personagem.GetVelocidade()}");

        Elementalista elementalista = new GameObject("Elementalista").AddComponent<Elementalista>();
        elementalista.SetNome("Eldrin");
        elementalista.SetEnergia(120);
        elementalista.SetForcaAtaque(10);
        elementalista.SetForcaDoPulo(3.5f);
        elementalista.SetVelocidade(5.0f);
        elementalista.SetElementoPrincipal("Fogo");
        elementalista.SetPoderMagico(80);

        Debug.Log($"Elementalista: {elementalista.GetNome()}, Energia: {elementalista.GetEnergia()}, Força de Ataque: {elementalista.GetForcaAtaque()}, Força do Pulo: {elementalista.GetForcaDoPulo()}, Velocidade: {elementalista.GetVelocidade()}, Elemento: {elementalista.GetElementoPrincipal()}, Poder Mágico: {elementalista.GetPoderMagico()}");

        elementalista.LançarFeitiço();

        bool mesmaEnergia = personagem.CompararEnergia(elementalista);
        Debug.Log($"Personagem Genérico e Elementalista têm a mesma energia? {mesmaEnergia}");
    }
}
