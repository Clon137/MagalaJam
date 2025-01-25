using UnityEngine;

public class Plyr2 : MonoBehaviour
{
   
    public float velocidad = 5f;  // Velocidad de movimiento
    [SerializeField] GameObject MenuWin;
    [SerializeField] GameObject Retrato;
    [SerializeField] Animator anim;

    public bool ganar;
    public bool lose;

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

     public void OnTriggerEnter2D (Collider2D other){

      if(other.gameObject.CompareTag("Obstacle"))
      {

        velocidad = 2f;
        Invoke("retornar",2);


        }

        if(other.gameObject.CompareTag("Meta")){

            ganar = true;
            MenuWin.SetActive(true);
            Retrato.SetActive(true);
            Invoke("Destener",4);
            
        } else {
        
            if(lose == true){

                anim.SetBool("isdie", true);
                Invoke("Destuir",2);

            }
        }
    }

    void retornar(){

        velocidad =5f;
    }

    void detener (){

        Time.timeScale = 0;
    }
}

