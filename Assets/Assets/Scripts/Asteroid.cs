using UnityEngine;

public class Asteroid : MonoBehaviour{
    public float speed = 3f;
    public int points;

    void Update(){
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        transform.Rotate(0, 0, 100 * Time.deltaTime);

        if(transform.position.y < -7){
            Destroy(gameObject);
        }
    }
}