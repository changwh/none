using UnityEngine;
using System.Collections;

public class MovingRotate : MonoBehaviour {

    public GameObject centerObj;
    public float speed;
    public GameObject rotateObj;
	// Use this for initialization
	void Start () {
	   
	}
	
	// Update is called once per frame
	void Update () {
        if (centerObj != null && rotateObj!=null)
        {
            //roateObj围绕centerObj旋转，x,y不旋转  
            rotateObj.transform.RotateAround(centerObj.transform.position, new Vector3(0, 0, 1), speed * Time.deltaTime);
            ////这里处理不然roateObj图片的显示位置发生变化  
            //Quaternion qua = rotateObj.transform.rotation;
            //qua.z = 0;
            //rotateObj.transform.rotation = qua;
        }
        if(centerObj == null && rotateObj != null)
        {
            rotateObj.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, 1), speed * Time.deltaTime);
            Rigidbody rigidbody = rotateObj.GetComponent<Rigidbody>();
            rigidbody.MovePosition(Vector3.zero);
        }
    }
}
