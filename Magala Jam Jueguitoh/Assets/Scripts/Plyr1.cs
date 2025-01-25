using Unity.VisualScripting;
using UnityEngine;

public class Plyr1 : MonoBehaviour

{

 [SerializeField] GameObject MenuWin;
    [SerializeField] GameObject Retrato;
    [SerializeField] Animator anim;

    public bool ganar;
    public bool lose;
     public float velocidad = 5f;  // Velocidad de movimiento

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
}
