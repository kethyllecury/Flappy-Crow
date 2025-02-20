using UnityEngine;

public class BackgroudController : MonoBehaviour
{
    public Renderer fundo;
    public float xOffset = 0f;
    public float velocidade = 3f;
    void Start()
    {
        fundo = GetComponent<Renderer>();
    }

    
    void Update()
    {
        xOffset += velocidade * Time.deltaTime;
        fundo.material.mainTextureOffset = new Vector2(xOffset, 0);
    }
}
