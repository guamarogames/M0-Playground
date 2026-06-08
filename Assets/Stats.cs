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
    }

    void Update()
    {
    }
}