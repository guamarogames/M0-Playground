using UnityEngine;

public class Stats : MonoBehaviour
{
    int vida = 100;
    float velocidade = 5.5f;
    bool vivo = true;
    string nome = "Tank";

void Start()
    {
        Debug.Log("Vida: " + vida);
        Debug.Log("Velocidade:" + velocidade);
         Debug.Log("Vivo: " + vivo);
     Debug.Log("Nome: "+ nome);
     vida = vida -10;

     if (vida <= 0)
        {
            Debug.Log("Status: Morto");
        }
        else if (vida <= 30)
        {
            Debug.Log("Status: Critico");
        }
        else if (vida <= 70)
        {
            Debug.Log("Status: Ferido");
        }
        else
        {
            Debug.Log("Status: Saudavel");
        }
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("Inimigo: " + i);
        }
        int contagem = 0;
        while (contagem < 5)
        {
            Debug.Log("Contagem: " + contagem);
            contagem++;
        }
    }

    void Update()
    {
    }
}