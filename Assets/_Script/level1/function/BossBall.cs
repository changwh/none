using UnityEngine;
using System.Collections;

public class BossBall : MonoBehaviour {
    public int blood=100;
    private Vector3 current;
    private Vector3 target;
    // Use this for initialization
    void Start () {
        current =   target- transform.position;
        gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.right, current);

    }
	
	// Update is called once per frame
	void Update () {
        switch (blood)
        {
            case 100:
            case 90:
            case 80:
            case 70:
            case 60:
            case 50:
            case 40:
            case 30:

            case 0:
            default:
                break;
        }

        if(blood<=0)
        {
            // youxi jieshu
            


        }
	}
}
