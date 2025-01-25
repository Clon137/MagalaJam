using UnityEngine;
using TMPro;

public class Tapon : MonoBehaviour
{
    [SerializeField] float time = 9;

    public static float altura;
    bool posicionguardada = false;
    Rigidbody2D rb;

    [SerializeField] TMP_Text tAltura, TGanador;

    [SerializeField] SpriteRenderer sprite;
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
            if (posicionguardada == false)
            {
                altura = transform.position.y;
                posicionguardada = true;
                tAltura.text = altura.ToString();
                if (altura > Tapon1.altura1)
                {
                    TGanador.text = "Ganador Pato";
                }
                else
                {
                    TGanador.text = "Ganador Unicornio";
                }
            }
            float velocidad = -Botella.jump * 3;
            rb.linearVelocity = Vector2.up * velocidad;

            sprite.flipY = true;
        }
        else
        {
            float velocidad = Botella.jump * 3;
            rb.linearVelocity = Vector2.up * velocidad;
        }

    }
}
