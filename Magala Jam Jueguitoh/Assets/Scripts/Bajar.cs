using UnityEngine;

public class Bajar : MonoBehaviour
{

    Rigidbody2D rb;

    [SerializeField] float timeCorch = 9;

    [SerializeField] Agitar agitar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        timeCorch = timeCorch - Time.deltaTime;
            if (timeCorch < 1)
            {
                timeCorch = 0;
                Agitar.subir = false;
                agitar.Impulso();
                Debug.Log("Llama funcion" + Agitar.subir);
            }

    }


    // void Bajar()
    // {
    //     rb.linearVelocity = new Vector2(0, 0);
    // }
}
