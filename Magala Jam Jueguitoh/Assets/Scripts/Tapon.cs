using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Tapon : MonoBehaviour
{
    [SerializeField] float time = 9;

    public static float altura;
    bool posicionguardada = false;
    Rigidbody2D rb;

    [SerializeField] TMP_Text tAltura, TGanador;

    [SerializeField] SpriteRenderer sprite;
    [SerializeField] GameObject Pato;
    [SerializeField] GameObject Uni;

    [SerializeField] GameObject Marco;

    [SerializeField] GameObject TaponUni;

    [SerializeField] Animator anim;

    // public static int scale = 0;
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
                Tapon1.altura1 = TaponUni.transform.position.y;
                posicionguardada = true;
                tAltura.text = altura.ToString();
                Compare();
                Invoke("SaliralMenu",4);

            }
            float velocidad = -Botella.jump * 3;
            rb.linearVelocity = Vector2.up * velocidad;
            anim.SetBool("isBaja", true);

            sprite.flipY = true;
        }
        else
        {
            float velocidad = Botella.jump * 3;
            rb.linearVelocity = Vector2.up * velocidad;
        }

    }

    void Compare()
    {
        if (altura > Tapon1.altura1)
        {
            Debug.Log("Pato" + altura + "Uni" + Tapon1.altura1);
            Pato.SetActive(true);
            Marco.SetActive(true);
            TGanador.text = "Ganador Pato";
        }
        else
        {
            Uni.SetActive(true);
            Marco.SetActive(true);
            TGanador.text = "Ganador Unicornio";
        }
    }

    void SaliralMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
