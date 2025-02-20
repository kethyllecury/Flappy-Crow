using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CrowMoviment : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocidade = 3f;
    public int milho;
    public int ultimoMilho = 0;
    public TMP_Text milhoText;
    
    void Start()
    {
       
       
        
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(0,velocidade);
        }
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Inimigo"))
        {
            Destroy(transform.gameObject); 
            SceneManager.LoadScene("GameOver");
            
            
        }
        if (collision.gameObject.CompareTag("Solo"))
        {
            Destroy(transform.gameObject); 
            SceneManager.LoadScene("GameOver");
            
            
        }

        if (collision.gameObject.CompareTag("Bonus"))
        {
            Destroy(collision.gameObject);
            milho++; 
            milhoText.text = milho.ToString();
            ultimoMilho = milho;
            PlayerPrefs.SetInt("UltimoMilho", ultimoMilho);
            PlayerPrefs.Save();
        }
    }
    
}
