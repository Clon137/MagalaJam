using UnityEngine;
using TMPro;

public class ComparativaAlturas : MonoBehaviour
{
    [SerializeField] TMP_Text TGanador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Tapon.altura > Tapon1.altura1){
            TGanador.text = "Ganador Pato";
        }else{
            TGanador.text = "Ganador Unicornio";
        }
    }
}
