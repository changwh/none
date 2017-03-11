using UnityEngine;
using System.Collections;

public class MovingToCenter : MonoBehaviour
{

    public float speed;
    Vector3 target;
    Rigidbody rb;
   


    void Timer()
    {
        //Debug.Log(string.Format("Timer3 is up !!! time=${0}", Time.time));
        speed = speed*3;
        Invoke("Timer", 2.0f);
    }


    // Use this for initialization
    void Start()
    {
        Invoke("Timer", 4.0f);
        target = new Vector3(0, 0, 0);
        rb = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.MovePosition(target);
        //Vector3.SmoothDamp();
        transform.position= Vector3.MoveTowards(transform.position, target, Time.deltaTime *  speed);
    }
}
