using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform target;  // El objeto que la cámara seguirá
    public Vector3 offset = new Vector3(0, 0, 0); // Ajuste de la posición de la cámara
    public float smoothSpeed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        if (target != null)  // Verifica si el objeto ha sido instanciado
        {
            Vector3 desiredPosition = target.position + offset;
            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        }
    }

    // Método para asignar el objetivo dinámicamente cuando se instancia
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
