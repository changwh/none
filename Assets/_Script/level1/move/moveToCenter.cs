using UnityEngine;
using System.Collections;

public class moveToCenter : MonoBehaviour {
    public float speed;
    Vector3 target;
    bool isStop;
    public bool istrigger;
	// Use this for initialization
	void Start () {
        target.x = 0.0f;
        target.y = 0.0f;
        target.z = 0.0f;
        
    }
	
	// Update is called once per frame
	void Update () {
        if (!isStop)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * 2 * speed * Time.timeScale);
        }
        if (istrigger)
        {
            if ((transform.position - target).magnitude < 0.1)
            {
                DestroyObject(gameObject);
            }
        }
    }
}
