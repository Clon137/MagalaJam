using UnityEngine;

public class Gancho : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("destroGa",4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void destroGa() {

        Destroy(gameObject);
    }
}

