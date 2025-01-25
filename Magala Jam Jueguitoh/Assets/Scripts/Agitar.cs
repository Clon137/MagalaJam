using UnityEngine;

public class Agitar : MonoBehaviour
{

    Rigidbody2D rb;

    [SerializeField] GameObject botella;

    [SerializeField] float time = 6;

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
                transform.position = new Vector3(0, 0, 0);
                Invoke("Impulso", 1);
                Debug.Log(transform.position.y);
                Debug.Log(Botella.jump);
            }
            else
            {
                float sec;
                sec = Mathf.Floor(time % 60);
                transform.position = botella.transform.position;
                Debug.Log(botella.transform.position.y);
            }
        
    }

    void Impulso(){
            
                rb.AddForce(Vector2.up * Botella.jump, ForceMode2D.Impulse);
               

    }
}
