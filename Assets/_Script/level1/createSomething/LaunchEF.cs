using UnityEngine;
using System.Collections;

// left fly e^x(0 2)

public class LaunchEF : MonoBehaviour
{
	public GameObject obj;
	public Vector3 objval;
	public float startWait;
	public float waveWait;
	public int objCount;
	public int waveCount;
	public float objSpeed;

	private float[] objWait;
	private float[] objlength;
	private float duan;
	void Start ()
	{
		//Debug.Log("begin start");
		if (objCount == 0) {
			return;
		}
		duan = 2f / (objCount+1);
		objWait = new float[objCount];
		objlength = new float[objCount];
		for (int i = 0; i < objCount; i++)
		{
			objlength[i]=Mathf.Exp (duan * (i+1));
		}
		for (int i = objCount-1; i > 0; i--) 
		{
			objWait [i] = objlength [i] - objlength [i - 1]/objSpeed;		
		}
		objWait [0] = waveWait;
		StartCoroutine(ObjLaunch());
		//Debug.Log("end start");
		//Debug.Log("duan:"+duan);
		//Debug.Log("obj wait:"+objWait[0]+","+objWait[1]+","+objWait[2]);
	}
		
	IEnumerator ObjLaunch()
	{
		yield return new WaitForSeconds (startWait);
		while (waveCount>0) {
			waveCount--;
			for (int i = 0; i < objCount; i++) {
				Vector3 objpos = new Vector3 (objval.x, 2 * objval.y * duan * (i + 1) / 2 - objval.y, objval.z);
				Quaternion objRotator = Quaternion.identity;
				GameObject instObj=Instantiate (obj, objpos, objRotator) as GameObject;
                instObj.AddComponent<MovingToCenter>().speed=0.4f;
				Rigidbody rb = instObj.transform.GetComponent<Rigidbody>();
				rb.velocity=new Vector3(1,0,0)*objSpeed;
				yield return new WaitForSeconds (objWait[objCount-i-1]);
			}
			//yield return new WaitForSeconds (waveWait);
		}
	}

}

