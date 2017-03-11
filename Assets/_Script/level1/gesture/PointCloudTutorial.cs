using UnityEngine;
using System.Collections;

public class PointCloudTutorial : MonoBehaviour {
    GameObject[] a;
    Vector3 objPosition;
    GameObject nextDel;
    public AudioSource soundOfDestroy;
    int i;
    //Vector3 center =new Vector3 (0, 0, 0);
    // Use this for initialization
    void Start () {
	   
	}
	
	// Update is called once per frame
	void Update () {
        
        a = GameObject.FindGameObjectsWithTag("gestureDestroy");

		if (a != null) {
			float[] distance=new float[a.Length];
			for (i=0;i<a.Length;i++)
			{
				objPosition = a[i].transform.position;
				distance[i] = objPosition.magnitude;
				//Debug.Log(i + ":" + distance[i]);
			}
			if (a.Length>0)
			{
				nextDel = a[0];
				for (i = 0; i < a.Length; i++)
				{
					if (distance[i] < nextDel.transform.position.magnitude)
					{
						nextDel = a[i];
					}
				}
			}
		}
	}
    void OnCustomGesture(PointCloudGesture gesture)
    {
       // Debug.Log("Recognized custom gesture: " + gesture.RecognizedTemplate.name +
       // ", match score: " + gesture.MatchScore +
       // ", match distance: " + gesture.MatchDistance);
        
       // Debug.Log(a.Length);
        Destroy(nextDel);
        soundOfDestroy.Play();
    }
}

