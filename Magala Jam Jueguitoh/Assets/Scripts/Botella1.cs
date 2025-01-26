using UnityEngine;

public class Botella1 : MonoBehaviour
{
    private bool abajo1 = false;

    public static int jump1;

    [SerializeField] float time = 5;

    [SerializeField] GameObject tapon1;

    [SerializeField] Animator anim;
    // [SerializeField] GameObject camara;
    // [SerializeField] GameObject camamal;


    bool tapon1SI = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jump1 = 1;
    }

    // Update is called once per frame
    void Update()
    {
        time = time - Time.deltaTime;
        if (time < 1)
        {
            time = 0;
            transform.position = new Vector3(65, 0, 0);
            if (tapon1SI)
            {
                tapon1SI = false;
                tapon1.SetActive(true);
                anim.SetBool("isSalta2",true);
            }



        }
        else
        {
            if (Countdown.adelante == true)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow) && abajo1)
                {
                    transform.position = new Vector3(65, transform.position.y - 2, 0);
                    abajo1 = false;
                }
                if (Input.GetKeyDown(KeyCode.RightArrow) && !abajo1)
                {
                    transform.position = new Vector3(65, transform.position.y + 2, 0);
                    abajo1 = true;
                    jump1++;
                }
            }

        }


    }
}
