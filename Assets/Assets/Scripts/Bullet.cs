using UnityEngine;

public class Bullet : MonoBehaviour{
    public float speed = 10f;
    public GameObject explosionPrefab;

    void Update(){
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Asteroid")){
            Destroy(other.gameObject);

            Asteroid asteroid = other.GetComponent<Asteroid>();
            GameManager.Instance.AddScore(asteroid.points);

            Instantiate(explosionPrefab, other.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}