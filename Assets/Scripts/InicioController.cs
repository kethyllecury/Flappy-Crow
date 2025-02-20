using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class InicioController : MonoBehaviour
{
    public TMP_Text ultimoMilhoText;
    public int ultimoMilho;

    void Start()
    {
        ultimoMilho = PlayerPrefs.GetInt("UltimoMilho", 0);
        ultimoMilhoText.text = ultimoMilho.ToString();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}