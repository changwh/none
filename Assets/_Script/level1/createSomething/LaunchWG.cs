using UnityEngine;
using System.Collections;

public class LaunchWG : MonoBehaviour {


    public GameObject obj;
    // public Vector3 objval;
    public float pos;

    public float objSpeed;
    public float objRoateSpeed;

    public float startWait;
    public float waveWait;
    public int objCount;


    // Use this for initialization
    void Start () {
        StartCoroutine(ObjLaunch());
    }


    IEnumerator ObjLaunch()
    {

        yield return new WaitForSeconds(startWait);
        Vector3[] objpos;
        objpos = new Vector3[4];
        objpos[0] = new Vector3(0, -pos, 0);

        objpos[1] = new Vector3(-pos, 0, 0);

        objpos[2] = new Vector3(0, pos, 0);

        objpos[3] = new Vector3(pos, 0, 0);

        for (int i = 0; i <4; i++)
        {
            for (int j = -objCount+1; j < objCount; j++)
            {
                Quaternion objRotator = Quaternion.identity;
                GameObject instObj = Instantiate(obj, WhatPost(objpos,i,j), objRotator) as GameObject;
                RotateAccelerating ra = instObj.GetComponent<RotateAccelerating>();
                ra.speed = objSpeed;
                yield return new WaitForSeconds(waveWait);
            }
           // yield return new WaitForSeconds(waveWait);
        }
    }
    private Vector3 WhatPost(Vector3[] objpos,int i,int j)
    {
        Vector3 rt=new Vector3(0,0,0);
        float k = j * 1.5f;
        switch (i)
        {
            case 0:
                rt = objpos[0] + new Vector3(k, 0);
                break;
            case 1:
                rt = objpos[1] + new Vector3(0, -k);
                break;
            case 2:
                rt = objpos[2] + new Vector3(-k, 0);
                break;
            case 3:
                rt = objpos[3] + new Vector3(0, k);
                break;
            default:
                break;
        }
        return rt;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
