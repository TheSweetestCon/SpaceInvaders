using UnityEngine;

public class AsteroidSpawner : MonoBehaviour{
    public GameObject asteroidPrefab;

    void Start(){
        InvokeRepeating(nameof(SpawnAsteroid), 1f, 2f);
    }

    void SpawnAsteroid(){
        
        float x = Random.Range(-8f, 8f);
        Vector3 pos = new Vector3(x, 6f, 0);
        GameObject asteroid = Instantiate(asteroidPrefab, pos, Quaternion.identity);
        float scale = Random.Range(0.05f, 0.4f);
        Asteroid asteroidScript = asteroid.GetComponent<Asteroid>();

        asteroidScript.points = Mathf.RoundToInt(Mathf.Lerp(10f, 1f, (scale - 0.05f) / 0.35f));
        asteroid.transform.localScale = Vector3.one * scale;
    }      
}