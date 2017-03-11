using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public int score = 0;
    public Text scoreText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void AddScore(int addon)
    {
        score += addon;
        UpdateScore();

    }
    void UpdateScore()
    {
        scoreText.text = "Score : " + score;
    }

}
