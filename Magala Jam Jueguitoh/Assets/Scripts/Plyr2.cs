using UnityEngine;

public class Plyr2 : MonoBehaviour
{
   
    public float velocidad = 5f;  // Velocidad de movimiento

    void Update()
    {
        // Movimiento del segundo jugador con teclas específicas
        float moverHorizontal = 0f;
        float moverVertical = 0f;

        // Detectar teclas de movimiento (puedes modificar estas teclas)
        if (Input.GetKey(KeyCode.LeftArrow))  // Izquierda
            moverHorizontal = -1f;
        if (Input.GetKey(KeyCode.RightArrow)) // Derecha
            moverHorizontal = 1f;

        if (Input.GetKey(KeyCode.UpArrow))    // Arriba
            moverVertical = 1f;
        if (Input.GetKey(KeyCode.DownArrow))  // Abajo
            moverVertical = -1f;

        // Mover al jugador
        Vector2 movimiento = new Vector2(moverHorizontal, moverVertical).normalized * velocidad * Time.deltaTime;
        transform.Translate(movimiento);
    }
}

