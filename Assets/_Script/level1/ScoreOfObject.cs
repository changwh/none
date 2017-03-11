using UnityEngine;
using System.Collections;

public class ScoreOfObject : MonoBehaviour {

    private Score score;
    public int scoreValue;

    // Use this for initialization
    void Start()
    {
        score = GameObject.Find("Center").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddScore()
    {
        score.AddScore(scoreValue);
    }
}
