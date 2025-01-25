using UnityEngine;

public class Peanut : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("destroPe",4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void destroPe() {

        Destroy(gameObject);
    }

}
