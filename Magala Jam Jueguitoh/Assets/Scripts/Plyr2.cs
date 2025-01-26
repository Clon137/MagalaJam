using UnityEngine;

public class Plyr2 : MonoBehaviour
{

    public float velocidad = 5f;  // Velocidad de movimiento
    [SerializeField] GameObject MenuWin;
    [SerializeField] GameObject Retrato;
    [SerializeField] Animator anim;

    public bool ganar;
    public static bool lose2;

    void Start()
    {
        lose2 = false;
    }

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

        if (lose2 == true)
            {

                anim.SetBool("isDead2", true);
                Debug.Log("Haz perdido");

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
            // Invoke("detener", 4);
            Plyr1.lose1 = true;

        }
    }

    void retornar()
    {

        velocidad = 5f;
    }

    // void detener()
    // {

    //     Time.timeScale = 0;
    // }
}

