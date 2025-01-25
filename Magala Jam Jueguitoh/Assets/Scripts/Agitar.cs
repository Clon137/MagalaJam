using UnityEngine;

public class Agitar : MonoBehaviour
{

    Rigidbody2D rb;

    [SerializeField] GameObject botella;
   
    [SerializeField] float time = 5;


    public static bool subir;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        subir = true;

    }

    // Update is called once per frame
    void Update()
    {
        time = time - Time.deltaTime;
            if (time < 1)
            {
                time = 0;
                
                Invoke("Impulso", 1);
            }
            else
            {
                float sec;
                sec = Mathf.Floor(time % 60);
                transform.position = botella.transform.position;
            }

    }

    public void Impulso()
    {
        if(subir){
            Debug.Log("Sube");
            float velocidad = Botella.jump / 2;
            transform.position = new Vector3(0, 0, 0);
            rb.linearVelocity = Vector2.up * velocidad;
            Debug.Log(rb.linearVelocity);
            


            // rb.AddForce(Vector2.up * Botella.jump, ForceMode2D.Impulse);
        }else{
            // Debug.Log("Baja");
            // rb.linearVelocity = new Vector2(0, 0);
        }
        
    }

    // void Bajar()
    // {
    //     rb.linearVelocity = new Vector2(0, 0);
    // }
}
