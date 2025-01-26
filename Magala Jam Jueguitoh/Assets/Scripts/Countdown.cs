using UnityEngine;
using TMPro;
public class Countdown : MonoBehaviour
{
    [SerializeField] float time = 4;
    [SerializeField] TMP_Text tCountdown;

    public static bool adelante = false;

    bool inicio = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!inicio)
        {
            time = time - Time.deltaTime;
            if (time < 1)
            {
                time = 0;


                tCountdown.text = "AGITAD";
                inicio = true;
                adelante = true;
                gameObject.SetActive(false);

            }
            else
            {
                float sec;
                sec = Mathf.Floor(time % 60);
                tCountdown.text = sec.ToString("0");
            }


        }
    }
}
