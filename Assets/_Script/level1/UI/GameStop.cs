using UnityEngine;
using System.Collections;

public class GameStop : MonoBehaviour {

    private int isStop = 0;
	// Use this for initialization
	void Start () {
        isStop = 0;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Stop()
    {
        if (isStop == 0)
        {
            Time.timeScale = 0;
            isStop = 1;
        }
        else
        {
            Time.timeScale = 1;
            isStop = 0;
        }
    }
}
