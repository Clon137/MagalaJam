using UnityEngine;
using System.Collections;

public class GanchoController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool isGenerating = false; // Controla si se generan números.
    private Coroutine randomNumberCoroutine; // Referencia a la corutina.
    public PosicionController movgancho; // Referencia al script del evento.ç

    

    private void Start()
    {
       
        if (movgancho == null)
        {
            movgancho = FindObjectOfType <PosicionController>(); // Busca el BossController en la escena.
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
            int randomNumber = Random.Range(1, 4); // Genera un número entre 1 y 3.
            Debug.Log($"Número aleatorio generado: {randomNumber}");

            // Envía el número al BossController.
            if (movgancho != null)
            {
                Debug.Log("Enviando número al BossController");
                movgancho.ReceiveRandomNumber(randomNumber); // Enviar el número al BossController.
            }

            yield return new WaitForSeconds(5f); // Espera 5 segundos antes de generar otro número.
        }
        Debug.Log("La generación de números se detuvo.");
    }
}
