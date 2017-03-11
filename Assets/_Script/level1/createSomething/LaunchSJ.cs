using UnityEngine;
using System.Collections;

public class LaunchSJ : MonoBehaviour {
    public GameObject obj;
    public float pos;
    public float startWait;
    public float waveWait;
    public int objCount;
    public int waveCount;
    public float objSpeed;

    // Use this for initialization
    void Start () {
        StartCoroutine(ObjLaunch());
    }
    IEnumerator ObjLaunch()
    {
        yield return new WaitForSeconds(startWait);
       
    }
    // Update is called once per frame
    void Update () {
	
	}
}
