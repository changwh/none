using UnityEngine;
using System.Collections;

public class slidebank : MonoBehaviour {
    private GameObject slide;
    private Vector3 position;
	// Use this for initialization
	void Start () {
        slide = GameObject.Find("slide");
    }
	
	// Update is called once per frame
	void Update () {
        position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1.0f));
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                slide.transform.position = position;
                slide.SetActive(true);
            }
            else
            {
                slide.SetActive(false);
            }
        }
        else
        {
            slide.SetActive(false);
        }
    }
}
