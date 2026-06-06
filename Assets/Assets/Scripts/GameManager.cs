using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour{
    public static GameManager Instance;
    public TextMeshProUGUI scoreText;
    private int score;

    private void Awake(){
        Instance = this;
    }

    public void AddScore(int points){

        score += points;
        scoreText.text = "Pontos: " + score;
    }
}