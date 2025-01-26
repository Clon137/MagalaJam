using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    [SerializeField] AudioClip sBotones;
    AudioSource audioSrc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToMainMenu(){
        audioSrc.PlayOneShot(sBotones);
        SceneManager.LoadScene("Main Menu");
    }
}
