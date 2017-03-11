using UnityEngine;
using System.Collections;

public class TapTutorial : MonoBehaviour {

    //定义一个Vector3,用来存储鼠标点击的位置
    private Vector3 position;
    public GameObject cube;
    public AudioSource soundOfDestroy;
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTap(TapGesture gesture)
    {
       
        if (gesture.Selection!=null && gesture.Selection.tag == "object")
        {
            Debug.Log("OK,Tap gesture detected at " + gesture.Position +". It was sent by " + gesture.Recognizer.name);
            Destroy(gesture.Selection);
            soundOfDestroy.Play();
            gesture.Selection.GetComponent<ScoreOfObject>().AddScore();
        }
        if (gesture.Selection != null && gesture.Selection.tag == "devided")
        {
            Debug.Log("OK1,Tap gesture detected at " + gesture.Position + ". It was sent by " + gesture.Recognizer.name);
            Vector3 devidedPosition = gesture.Selection.transform.position;
            Quaternion devidedRotator = Quaternion.identity;
            Instantiate(cube, devidedPosition, devidedRotator);
            Destroy(gesture.Selection);
            soundOfDestroy.Play();
            gesture.Selection.GetComponent<ScoreOfObject>().AddScore();
        }
        else
        {
            Debug.Log("Tap gesture detected at " + gesture.Position + ". It was sent by " + gesture.Recognizer.name);
        }
    }
}

