using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controllmusicameta : MonoBehaviour
{
    [SerializeField] AudioClip adwiner, adfan, adexplo;

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

    void OnTriggerEnter2D (Collider2D other){

        if(other.gameObject.tag == "Player"){

          audioSrc.PlayOneShot(adwiner);
          audioSrc.PlayOneShot(adfan);

          Invoke("Menu",4);
        }
    }

    void Menu (){

        SceneManager.LoadScene("Main Menu");
        
    }
}
