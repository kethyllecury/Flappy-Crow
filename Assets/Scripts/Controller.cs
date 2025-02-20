using System.Collections;
using UnityEngine;


public class Controller : MonoBehaviour
{
    public float timer = 3f; 
    public GameObject obstaculo;
    public Vector2 posicao;
    public float tempoMaximo = 30f;
    public bool Criar = true;

    void Start()
    {
        StartCoroutine(GerenciarCriacaoObstaculos());
    }

    void Update()
    {
        
    }

    IEnumerator GerenciarCriacaoObstaculos()
    {
        while (true) 
        {
            if (Criar)
            {
                float tempoDecorrido = 0f;

                while (tempoDecorrido < tempoMaximo)
                {
                    yield return new WaitForSeconds(timer);
                    Instantiate(obstaculo, posicao, Quaternion.identity);
                    yield return new WaitForSeconds(timer); 
                    tempoDecorrido += timer; 
                }

                yield return new WaitForSeconds(tempoMaximo); 
            }
            else
            {
                yield return null; 
            }
        }
    }
    
}