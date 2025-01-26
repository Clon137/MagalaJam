using UnityEngine;

public class Botella : MonoBehaviour
{
    private bool abajo = false;

    public static int jump;

    public static bool Paso;

    [SerializeField] float time = 5;

    [SerializeField] GameObject tapon;
    [SerializeField] Animator anim;

    // [SerializeField] GameObject camara;
    // [SerializeField] GameObject camamal;


    bool taponSI = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jump = 1;
        //Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time = time - Time.deltaTime;
        if (time < 1)
        {
            time = 0;
            transform.position = new Vector3(0, 0, 0);
            if (taponSI)
            {
                taponSI = false;
                tapon.SetActive(true);
                anim.SetBool("isSalta",true);
                Tapon.Corcho = true;
                Paso = Tapon.Corcho;
            }



        }
        else
        {
            if (Countdown.adelante == true)
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

        }


    }
}
