using UnityEngine;

public class Tapon : MonoBehaviour
{
    [SerializeField] float time = 9;

    private float altura;
    bool posicionguardada = false;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        time = time - Time.deltaTime;
            if (time < 1)
            {
                time = 0;
                if(posicionguardada == false){
                    altura = transform.position.y;
                    posicionguardada = true;
                    Debug.Log(altura);
                }
                float velocidad = -Botella.jump * 3;
                rb.linearVelocity = Vector2.up * velocidad;
            }
            else
            {
                float velocidad = Botella.jump * 3;
                rb.linearVelocity = Vector2.up * velocidad;
            }
            
    }
}
