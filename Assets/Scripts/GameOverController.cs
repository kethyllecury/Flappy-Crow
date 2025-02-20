using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public float timer = 2f;
    public float timerinicial = 0f;
    
    void Start()
    {
        timerinicial += Time.deltaTime;
    }

  
    void Update()
    {
        timerinicial += Time.deltaTime;
        if (timerinicial >= timer)
        {
            SceneManager.LoadScene("Inicio");
        }
    }
}