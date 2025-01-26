using UnityEngine;
using TMPro;


public class Tapon1 : MonoBehaviour
{
    [SerializeField] float time = 9;

    public static float altura1;

    public static float altmax;
    bool posicionguardada1 = false;
    Rigidbody2D rb;

    [SerializeField] TMP_Text tAltura1;

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
                if(posicionguardada1 == false){
                    altura1 = transform.position.y;
                    GuardarAltura();
                    posicionguardada1 = true;
                    tAltura1.text = altura1.ToString();
                }
                float velocidad = -Botella1.jump1 * 3;
                rb.linearVelocity = Vector2.up * velocidad;

                sprite.flipY = true;
            }
            else
            {
                float velocidad = Botella1.jump1 * 3;
                rb.linearVelocity = Vector2.up * velocidad;
            }
            
    }
    void GuardarAltura(){
        altmax = altura1;
        Debug.Log("AltMax" + altmax + "Altura1" + altura1);
    }
}
