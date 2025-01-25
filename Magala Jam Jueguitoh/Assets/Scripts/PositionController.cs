using UnityEngine;

public class PosicionController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
    public static int posigancho;
  
    void Start()
    {
        posigancho = 0;
    }

   public void ReceiveRandomNumber(int randomNumber)
    {
        // Procesa el número aleatorio recibido.
        Debug.Log($"El Boss recibió el número aleatorio: {randomNumber}");

        // Lógica específica según el número recibido.
        switch (randomNumber)
        {
            
            case 1:

                posigancho = -35;
                Debug.Log("Se instancio en  la pos 35");
                break;
            case 2:
                posigancho = -30;
                Debug.Log("Se instancio en  la pos 30");
                break;
            case 3:
                   posigancho = -25;
                   Debug.Log("Se instancio en  la pos 32");
                break;
        }

        
    }

   
}
