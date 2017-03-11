using UnityEngine;
using System.Collections;

public class LaunchFB : MonoBehaviour {
    public GameObject obj;
    public GameObject objsec;

    public Vector3 objval;
    public Vector3 objvalsec;

    public float startWait;
    public float waveWait;
    private int objCount;
    private int waveCount;
    public float objSpeed;



    // Use this for initialization
    void Start () {
        StartCoroutine(ObjLaunch());
    }

    IEnumerator ObjLaunch()
    {
        yield return new WaitForSeconds(startWait);
        do
        {
            switch (waveCount)
            {
                case 0:
                    Vector3 objpos1 = new Vector3(objval.x, objval.y+1.5f, objval.z);
                    Quaternion objRotator = Quaternion.identity;
                    GameObject instObj = Instantiate(obj, objpos1, objRotator) as GameObject;
                    Rigidbody rb = instObj.transform.GetComponent<Rigidbody>();
                    rb.velocity = new Vector3(1, 0, 0) * objSpeed;

                    objpos1 = new Vector3(objval.x, -objval.y - 1.5f, objval.z);
                    instObj = Instantiate(obj, objpos1, objRotator) as GameObject;
                    rb = instObj.transform.GetComponent<Rigidbody>();
                    rb.velocity = new Vector3(1, 0, 0) * objSpeed;
                    yield return new WaitForSeconds(waveWait*2);
                    break;
                case 1:
                    objpos1 = new Vector3(objval.x, objval.y + 3f, objval.z);
                    objRotator = Quaternion.identity;
                    instObj = Instantiate(obj, objpos1, objRotator) as GameObject;
                    rb = instObj.transform.GetComponent<Rigidbody>();
                    rb.velocity = new Vector3(1, 0, 0) * objSpeed*2.5f;

                    objpos1 = new Vector3(objval.x, -objval.y - 3f, objval.z);
                    instObj = Instantiate(obj, objpos1, objRotator) as GameObject;
                    rb = instObj.transform.GetComponent<Rigidbody>();
                    rb.velocity = new Vector3(1, 0, 0) * objSpeed*2.5f;
                    yield return new WaitForSeconds(waveWait);
                    break;

                case 2:
                    objpos1 = new Vector3(objval.x, 0, objval.z);
                    objRotator = Quaternion.identity;
                    instObj = Instantiate(objsec, objpos1, objRotator) as GameObject;
                    rb = instObj.transform.GetComponent<Rigidbody>();
                    rb.velocity = new Vector3(1, 0, 0) * objSpeed*5f;

                    objpos1 = new Vector3(-objval.x,0, objval.z);
                    instObj = Instantiate(obj, objpos1, objRotator) as GameObject;
                    rb = instObj.transform.GetComponent<Rigidbody>();
                    rb.velocity = new Vector3(-1, 0, 0) * objSpeed*5f;
                    yield return new WaitForSeconds(waveWait*2);
                    break;
                case 3:
                    objpos1 = new Vector3(objvalsec.x+2, objvalsec.y, objvalsec.z);
                    objRotator = Quaternion.identity;
                    instObj = Instantiate(obj, objpos1, objRotator) as GameObject;
                    rb = instObj.transform.GetComponent<Rigidbody>();
                    Vector3 vec = Vector3.zero - rb.transform.position;
                    rb.velocity = vec.normalized * objSpeed*1.5f;

                    objpos1 = new Vector3(objvalsec.x+2, -objvalsec.y, objvalsec.z);
                    instObj = Instantiate(obj, objpos1, objRotator) as GameObject;
                    rb = instObj.transform.GetComponent<Rigidbody>();
                    vec = Vector3.zero - rb.transform.position;
                    rb.velocity = vec.normalized * objSpeed * 1.5f;

                    objpos1 = new Vector3(objvalsec.x + 4, objvalsec.y, objvalsec.z);
                    instObj = Instantiate(obj, objpos1, objRotator) as GameObject;
                    rb = instObj.transform.GetComponent<Rigidbody>();
                    vec = Vector3.zero - rb.transform.position;
                    rb.velocity = vec.normalized * objSpeed*1.5f;

                    objpos1 = new Vector3(objvalsec.x + 4, -objvalsec.y, objvalsec.z);
                    instObj = Instantiate(obj, objpos1, objRotator) as GameObject;
                    rb = instObj.transform.GetComponent<Rigidbody>();
                    vec = Vector3.zero - rb.transform.position;
                    rb.velocity = vec.normalized * objSpeed*1.5f;
                    yield return new WaitForSeconds(waveWait*2.5f);
                    
                    break;
                case 4:
                    objpos1 = new Vector3(-objvalsec.x-2, objvalsec.y, objvalsec.z);
                    objRotator = Quaternion.identity;
                    instObj = Instantiate(objsec, objpos1, objRotator) as GameObject;
                    rb = instObj.transform.GetComponent<Rigidbody>();
                    vec = Vector3.zero - rb.transform.position;
                    rb.velocity = vec.normalized * objSpeed*6;

                    objpos1 = new Vector3(-objvalsec.x-2, -objvalsec.y, objvalsec.z);
                    instObj = Instantiate(objsec, objpos1, objRotator) as GameObject;
                    rb = instObj.transform.GetComponent<Rigidbody>();
                    vec = Vector3.zero- rb.transform.position;
                    rb.velocity = vec.normalized * objSpeed*6;
                    break;
                default:
                    waveCount = -1;
                    break;
            }
            waveCount++;
        } while (waveCount > 0);
    }



    // Update is called once per frame
    void Update () {
	
	}
}
