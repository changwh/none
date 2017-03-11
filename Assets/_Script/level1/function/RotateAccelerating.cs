using UnityEngine;
using System.Collections;

public class RotateAccelerating : MonoBehaviour {
    Vector3 target;
    public float speed;
    public float tim;
    private Vector3 current;
    private Vector3 vertical;
    private Quaternion targetQ;
    private Quaternion last;
    private Quaternion q = Quaternion.Euler(0, 0, 90);

    // Use this for initialization
    void Start () {
        current = transform.position - target;
        Invoke("Timer", tim);

        if(transform.position.y != 0)
        { 
            vertical = q * current;
            float angle = Vector3.Angle(new Vector3(0,gameObject.transform.position.y), vertical);
            gameObject.transform.rotation = gameObject.transform.rotation * Quaternion.Euler(0, 0, angle);
        }
        //Quaternion.Slerp(gameObject.transform.rotation, q*gameObject.transform.rotation,)
        targetQ = q * gameObject.transform.rotation;
        last = Quaternion.identity;

    }

    void Timer()
    {
        //Debug.Log(string.Format("Timer3 is up !!! time=${0}", Time.time));
        speed = 0.2f;
       // Invoke("Timer", 2.0f);
    }

    // Update is called once per frame
    void Update () {

        gameObject.transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, targetQ, Time.deltaTime*1.5f);
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);



       // Debug.Log(last+"---"+ targetQ);
        float f=Quaternion.Angle(transform.rotation, targetQ);

       //Debug.Log(f);
        if (f<7 && f>-7)
        {
            speed =20 ;
        }





        //current = transform.position - target;
        //Quaternion q = Quaternion.Euler(0, 0, 90);
        //vertical = q * current;
        //float angle = Vector3.Angle(Vector3.up, vertical);
        //gameObject.transform.rotation = gameObject.transform.rotation * Quaternion.Euler(0, 0, angle);
        //Vector3.RotateTowards  Quaternion.Euler(0,0,angle)
        //Quaternion q = Quaternion.Euler(0, 0, 90);
        //Vector3 v=q* current;
        //    Vector3.Angle
        //    Vector3.Lerp
    }
}
