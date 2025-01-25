using UnityEngine;

public class Eventos2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] GameObject Boqueron;
    [SerializeField] GameObject Gancho;
    [SerializeField] GameObject Cacahuetes;
    [SerializeField] GameObject Captain;

    // [SerializeField] PosicionController controllGancho;
    void Start()
    {
        
    }

   public void ReceiveRandomNumber(int randomNumber)
    {
        // Procesa el número aleatorio recibido.
        Debug.Log($"El Boss recibió el número aleatorio: {randomNumber}");

        // Lógica específica según el número recibido.
        switch (randomNumber)
        {
            case 1:

                Invoke("boqueron",2);
                Debug.Log("se llama al boqueron.");
                break;
            case 2:
                    Invoke("gancho",2);
                Debug.Log("El Boss realiza la acción 2.");
                break;
            case 3:
                    Invoke("Cacahuete",2);
                Debug.Log("El Boss realiza la acción 3.");
                break;

                 case 4:

                Invoke("boqueron",2);
                Debug.Log("se llama al boqueron.");
                break;
            case 5:
                    Invoke("gancho",2);
                Debug.Log("El Boss realiza la acción 2.");
                break;
            case 6:
                    Invoke("Cacahuete",2);
                Debug.Log("El Boss realiza la acción 3.");
                break;

                 case 7:
                    Invoke("malaga",2);
                Debug.Log("El Boss realiza la acción 3.");
                break;
        }
    }

    void boqueron(){

        Instantiate(Boqueron, new Vector3(20f, transform.position.y + 10, 0), Quaternion.identity);
        Debug.Log("EventoLLamadoBoqueron");
        
        
    }

    void gancho(){

       Instantiate(Gancho, new Vector3(transform.position.x+ PosicionController.posigancho, transform.position.y + 20, 0), Quaternion.identity);
      
    }

    void Cacahuete(){
         Instantiate(Cacahuetes, new Vector3(transform.position.x + PosicionController.posigancho, transform.position.y + 20, 0), Quaternion.identity);
        Debug.Log("EventoLLamadoCaca");
        

    }

    void malaga(){
         Instantiate(Captain, new Vector3(transform.position.x + PosicionController.posigancho, transform.position.y + 20, 0), Quaternion.identity);
        Debug.Log("EventoLLamadoCaca");
        

    }

   
}