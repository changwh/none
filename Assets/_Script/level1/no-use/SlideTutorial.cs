using UnityEngine;
using System.Collections;

public class SlideTutorial : MonoBehaviour {
    //定义一个Vector3,用来存储鼠标点击的位置
    private Vector3 position;
    private Vector2 firstposition, secondposition;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0))
        {
            position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1.0f));
            secondposition = firstposition;
            firstposition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1.0f));
            secondposition = firstposition;
            firstposition = Input.mousePosition;

            if (firstposition != secondposition)
            {
                Ray ray = Camera.main.ScreenPointToRay(position);//从摄像机发出到点击坐标的射线
                RaycastHit hitInfo;
                Physics.Raycast(ray, out hitInfo);
           
                if(Physics.Raycast(ray,out hitInfo))
                {
                      Debug.DrawLine(ray.origin,hitInfo.point);//划出射线，只有在scene视图中才能看到
                      GameObject gameObj = hitInfo.collider.gameObject;
                      Debug.Log("click object name is " + gameObj.name);
                  if(gameObj.tag == "Cylinder")//当射线碰撞目标为Cylinder类型的物品
                    {
                     Debug.Log("pick up!");
                  }
                  
                }
                else Debug.Log("fuck up!");
            }

         }
    }
}
