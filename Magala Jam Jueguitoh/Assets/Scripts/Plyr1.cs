using Unity.VisualScripting;
using UnityEngine;

public class Plyr1 : MonoBehaviour

{

    [SerializeField] GameObject MenuWin;
    [SerializeField] GameObject Retrato;
    [SerializeField] Animator anim1;

    public bool ganar;
    public static bool lose1;
    public float velocidad = 5f;  // Velocidad de movimiento

    void Start()
    {
        lose1 = false;
    }

    void Update()
    {
        // Movimiento del segundo jugador con teclas específicas
        float moverHorizontal = 0f;
        float moverVertical = 0f;

        // Detectar teclas de movimiento (puedes modificar estas teclas)
        if (Input.GetKey(KeyCode.A))  // Izquierda
            moverHorizontal = -1f;
        if (Input.GetKey(KeyCode.D)) // Derecha
            moverHorizontal = 1f;

        if (Input.GetKey(KeyCode.W))    // Arriba
            moverVertical = 1f;
        if (Input.GetKey(KeyCode.S))  // Abajo
            moverVertical = -1f;

        // Mover al jugador
        Vector2 movimiento = new Vector2(moverHorizontal, moverVertical).normalized * velocidad * Time.deltaTime;
        transform.Translate(movimiento);

         if (lose1 == true)
            {

                anim1.SetBool("isDead", true);
                Invoke("detener", 2);
                Debug.Log("Has perdidoply1");


            }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Obstacle"))
        {

            velocidad = 2f;
            Invoke("retornar", 2);


        }

        if (other.gameObject.CompareTag("Meta"))
        {

            ganar = true;
            MenuWin.SetActive(true);
            Retrato.SetActive(true);
            Invoke("detener", 2);
            Plyr2.lose2 = true;

        }
    }

    void retornar()
    {

        velocidad = 5f;
    }

    void detener()
    {

        Time.timeScale = 0;
    }
}
