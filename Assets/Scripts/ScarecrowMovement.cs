using UnityEngine;

public class ScarecrowMovement : MonoBehaviour
{
    public float velocidade = 5f;
 

    void Start()
    {
        transform.position += Vector3.left * velocidade * Time.deltaTime;
    }

    void Update()
    {
        
        transform.position += Vector3.left * velocidade * Time.deltaTime;
        
    }
    

    
}