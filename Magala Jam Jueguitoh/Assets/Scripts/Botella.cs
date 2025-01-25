using UnityEngine;

public class Botella : MonoBehaviour
{
    private bool abajo = false;

    public static int jump;

    [SerializeField] float time = 6;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jump = 1;
    }

    // Update is called once per frame
    void Update()
    {
        time = time - Time.deltaTime;
        if (time < 1)
        {
            time = 0;
            transform.position = new Vector3(0, 0, 0);

            Debug.Log(transform.position.y);
            Debug.Log(Botella.jump);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.A) && abajo)
            {
                transform.position = new Vector3(0, transform.position.y - 2, 0);
                abajo = false;
            }
            if (Input.GetKeyDown(KeyCode.D) && !abajo)
            {
                transform.position = new Vector3(0, transform.position.y + 2, 0);
                abajo = true;
                jump++;
            }
        }


        Debug.Log(jump);

    }
}
