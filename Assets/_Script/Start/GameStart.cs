using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {
    private GameObject title;
    private GameObject start;
    private GameObject exit;
    private Vector3 oriTitlePos;
    private Vector3 oriStartPos;
    private Vector3 oriExitPos;
    public Vector3 titlePos;
    public Vector3 startPos;
    public Vector3 exitPos;
	// Use this for initialization
	void Start () {
        title = GameObject.Find("Title");
        start = GameObject.Find("Start");
        exit = GameObject.Find("Exit");

        oriTitlePos = title.transform.position;
        oriStartPos = start.transform.position;
        oriExitPos = exit.transform.position;

        title.transform.position-= titlePos;
        start.transform.position += startPos;
        exit.transform.position += exitPos;

        titlePos = new Vector3(25, 0, 0);
        startPos = new Vector3(10, 0, 0);
        exitPos = new Vector3(10, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (title.transform.position.x < oriTitlePos.x)
        {
            title.transform.position += titlePos;
        }
        if (start.transform.position.x > oriStartPos.x)
        {
            start.transform.position -= startPos;
        }
        if (exit.transform.position.x > oriExitPos.x)
        {
            exit.transform.position -= exitPos;
        }
    }
    
    public void Game_Start()
    {
        Application.LoadLevel(1);
    }
}
