using UnityEngine;

public class Aparecerburbuja : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] GameObject Ply1;
    [SerializeField] GameObject Ply2;
    [SerializeField] GameObject cam;
    void Start()
    {
        Invoke("apa",2);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void apa(){

         Ply1.SetActive(true);
        Ply2.SetActive(true);
        cam.SetActive(false);
    }

}
