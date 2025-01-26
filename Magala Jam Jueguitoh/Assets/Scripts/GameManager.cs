using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool pausado = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(pausado){
            Time.timeScale = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
