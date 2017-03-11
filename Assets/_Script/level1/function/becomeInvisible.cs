using UnityEngine;
using System.Collections;

public class becomeInvisible : MonoBehaviour {
    // Use this for initialization
    Color c;
    public float distance;
    void Start () {
        c = GetComponent<MeshRenderer>().material.color;
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.magnitude < distance)
        {
           // Debug.Log("Color:" + GetComponent<MeshRenderer>().material.color);
            c.a -= 0.01f;
            GetComponent<MeshRenderer>().material.color = c;
        }
	}
}
