using UnityEngine;

public class Tapon1 : MonoBehaviour
{
    [SerializeField] float time = 9;

    private float altura1;
    bool posicionguardada1 = false;
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
                if(posicionguardada1 == false){
                    altura1 = transform.position.y;
                    posicionguardada1 = true;
                    Debug.Log(altura1);
                }
                float velocidad = -Botella1.jump1 * 3;
                rb.linearVelocity = Vector2.up * velocidad;
            }
            else
            {
                float velocidad = Botella1.jump1 * 3;
                rb.linearVelocity = Vector2.up * velocidad;
            }
            
    }
}
