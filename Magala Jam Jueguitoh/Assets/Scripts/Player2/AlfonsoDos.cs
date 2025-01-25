using UnityEngine;

public class AlfonsoDos : MonoBehaviour
{
      [SerializeField] int speed = 3;
    [SerializeField] Vector3 endPos;
    Vector3 startPos;
    bool gogoend = true;

[SerializeField] SpriteRenderer sprite;
[SerializeField] GameObject Crab;
float prevXposition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Start()
    {
         startPos = transform.position;

        prevXposition =transform.position.x;

        Invoke("destroAl",15);
    }

    // Update is called once per frame
    void Update()
    {
       {
        
        if (gogoend){

            transform.position = Vector3.MoveTowards(transform.position, endPos, speed * Time.deltaTime); // La velocidad se 
        
             if( transform.position == endPos ){        

                 gogoend = false;
                 }
        } else {
            transform.position = Vector3.MoveTowards(transform.position,startPos, speed * Time.deltaTime);
             if( transform.position == startPos){
    
            gogoend =true;
    
            }
        }

        if (transform.position.x > prevXposition){

            sprite.flipX = false;
        } else if (transform.position.x< prevXposition){
            sprite.flipX = true;

        }

        prevXposition = transform.position.x;

}
    }

    void destroAl() {

        Destroy(gameObject);
    }
}
