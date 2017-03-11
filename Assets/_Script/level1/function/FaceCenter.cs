using UnityEngine;
using System.Collections;

public class FaceCenter : MonoBehaviour {

    private Vector3 current;
    private Vector3 target;


	// Use this for initialization
	void Start () {
        current =   target- transform.position;
        gameObject.transform.rotation =Quaternion.FromToRotation(new Vector3(0, 1), current);
       // }
    }
	
	// Update is called once per frame
	void Update () {

    ;
    }
}
