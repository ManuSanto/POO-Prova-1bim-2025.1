using UnityEngine;

public class MovimentoSimples : MonoBehaviour
{
    public float velocidade = 5f;

    void Update()
    {
        float moverX = Input.GetAxis("Horizontal");
        float moverZ = Input.GetAxis("Vertical");

        Vector3 direcao = new Vector3(moverX, 0f, moverZ);
        transform.Translate(direcao * velocidade * Time.deltaTime);
    }
}