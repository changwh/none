using UnityEngine;
using System.Collections;

public class motionfigure : MonoBehaviour {
    private GameObject slide;
    private Vector3 position;
    // Use this for initialization
    void Start () {
        slide = GameObject.Find("slide");
        if (slide = GameObject.Find("slide"))
        {
            slide.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
        position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,10.0f));
    }

    void OnFingerMove(FingerMotionEvent e)
    {
        slide.transform.position = position;
        slide.SetActive(true);
        //float elapsed = e.ElapsedTime;
        //if (e.Phase == FingerMotionPhase.Started)
        //    Debug.Log(e.Finger + " started moving at " + e.Position);
        //else if (e.Phase == FingerMotionPhase.Updated)
        //    Debug.Log(e.Finger + " moving at " + e.Position);
        //else if (e.Phase == FingerMotionPhase.Ended)
        //    Debug.Log(e.Finger + " stopped moving at " + e.Position);
        float elapsed = e.ElapsedTime;
        if (e.Phase == FingerMotionPhase.Ended)
        {
            slide.SetActive(false);
        }

    }
    void OnFingerStationary(FingerMotionEvent e)
    {
        slide.SetActive(false);
        //float elapsed = e.ElapsedTime;
        //if (e.Phase == FingerMotionPhase.Started)
        //    Debug.Log(e.Finger + " started stationary state at " + e.Position);
        //else if (e.Phase == FingerMotionPhase.Updated)
        //    Debug.Log(e.Finger + " is still stationary at " + e.Position);
        //else if (e.Phase == FingerMotionPhase.Ended)
        //    Debug.Log(e.Finger + " stopped being stationary at " + e.Position);
    }
}
