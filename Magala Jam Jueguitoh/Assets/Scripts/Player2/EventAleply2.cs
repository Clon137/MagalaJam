using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class EventAleply2 : MonoBehaviour
{
   public bool isGenerating = false; // Controla si se generan números.
    private Coroutine randomNumberCoroutine; // Referencia a la corutina.
    public Eventos2 eventos2jeje;
    
    public PosicionController jeje; // Referencia al script del evento.

    

    private void Start()
    {
       
        if (eventos2jeje == null)
        {
            eventos2jeje = FindObjectOfType <Eventos2>(); // Busca el BossController en la escena.
        }
    }

      private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto que entra tiene el tag "Player".
        if (!isGenerating && other.CompareTag("Player"))
        {
            isGenerating = true; // Activa la generación de números.
            randomNumberCoroutine = StartCoroutine(GenerateRandomNumbers());
        }
    }
    private IEnumerator GenerateRandomNumbers()
    {
        while (isGenerating) // Genera números mientras isGenerating sea true.
        {
            int randomNumber = Random.Range(1, 8); // Genera un número entre 1 y 3.
            Debug.Log($"Número aleatorio generado: {randomNumber}");

            // Envía el número al BossController.
            if (eventos2jeje != null)
            {
                Debug.Log("Enviando número al BossController");
                eventos2jeje.ReceiveRandomNumber(randomNumber);
                jeje.ReceiveRandomNumber(randomNumber); // Enviar el número al BossController.
            }

            yield return new WaitForSeconds(5f); // Espera 5 segundos antes de generar otro número.
        }
        Debug.Log("La generación de números se detuvo.");
    }

    // Método público para detener la generación de números.


    void OnTriggerExit2D(Collider2D other){

 isGenerating = false; // Cambia el estado para detener la corutina.

        if (randomNumberCoroutine != null) // Asegura que la corutina se detenga si está activa.
        {
            StopCoroutine(randomNumberCoroutine);
            randomNumberCoroutine = null;

            Debug.Log("Se acabó la generación de números.");
        }
    }
    
    }
