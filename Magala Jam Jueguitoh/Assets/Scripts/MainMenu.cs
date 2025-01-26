using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoLevel1(){
        SceneManager.LoadScene("Level1");
    }

    public void GoLevel2(){
        SceneManager.LoadScene("Level2");
    }

     public void GoCreditos(){
        SceneManager.LoadScene("Creditos");
    }
    public void GoToMainMenu(){
        SceneManager.LoadScene("Main Menu");
    }
    
    public void Play(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void Salir(){
        Application.Quit();
    }
}

