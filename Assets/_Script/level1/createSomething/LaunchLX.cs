using UnityEngine;
using System.Collections;




public class LaunchLX : MonoBehaviour {
    public GameObject obj;
    public GameObject objsec;
    public GameObject empty;



    public Vector3 objval;
    public Vector3 objvalsec;

    public float objSpeed;
    public float objRoateSpeed;

    public float startWait;
    public float waveWait;
    private int objCount;
    private int waveCount;


    // Use this for initialization
    void Start()
    {
        StartCoroutine(ObjLaunch());
    }

    IEnumerator ObjLaunch()
    {
        float range=1f;
        yield return new WaitForSeconds(startWait);
        do
        {
            switch (waveCount) {
                case 0:
                    Vector3 objpos1 = new Vector3(objval.x, objval.y, objval.z);
                    Quaternion objRotator = Quaternion.identity;
                    GameObject instEmp = Instantiate(empty, objpos1,objRotator) as GameObject;

                    moveToCenter mc= instEmp.AddComponent<moveToCenter>();
                    mc.istrigger = true;
                    mc.speed = objSpeed;

                    float x= Random.Range(-range, range);
                    float y = Mathf.Sqrt(range*range - x * x);

                    objpos1.x += x;
                    objpos1.y += y;

                    GameObject instObj = Instantiate(obj, objpos1, objRotator) as GameObject;
                    MovingRotate mr=instObj.AddComponent<MovingRotate>();
                    mr.rotateObj =instObj;
                    mr.centerObj =instEmp;
                    mr.speed = objRoateSpeed;

                    yield return new WaitForSeconds(waveWait);
                    break;
                case 1: 
                    objpos1 = new Vector3(-objval.x, objval.y, objval.z);
                    objRotator = Quaternion.identity;
                    instEmp = Instantiate(empty, objpos1, objRotator) as GameObject;

                    mc = instEmp.AddComponent<moveToCenter>();
                    mc.istrigger = true;
                    mc.speed = objSpeed;

                    x = Random.Range(-range, range);
                    y = Mathf.Sqrt(range*range - x * x);

                    objpos1.x += x;
                    objpos1.y += y;

                    instObj = Instantiate(obj, objpos1, objRotator) as GameObject;
                    mr = instObj.AddComponent<MovingRotate>();
                    mr.rotateObj = instObj;
                    mr.centerObj = instEmp;
                    mr.speed = objRoateSpeed;

                    yield return new WaitForSeconds(waveWait);
                    break;
                case 2:
                    objpos1 = new Vector3(-objval.x, -objval.y, objval.z);
                    objRotator = Quaternion.identity;
                    instEmp = Instantiate(empty, objpos1, objRotator) as GameObject;

                    mc = instEmp.AddComponent<moveToCenter>();
                    mc.istrigger = true;
                    mc.speed = objSpeed;

                    x = Random.Range(-range, range);
                    y = Mathf.Sqrt(range*range - x * x);

                    objpos1.x += x;
                    objpos1.y += y;

                    instObj = Instantiate(obj, objpos1, objRotator) as GameObject;
                    mr = instObj.AddComponent<MovingRotate>();
                    mr.rotateObj = instObj;
                    mr.centerObj = instEmp;
                    mr.speed = objRoateSpeed;

                    yield return new WaitForSeconds(waveWait);
                    break;
                case 3:
                    objpos1 = new Vector3(objval.x, -objval.y, objval.z);
                    objRotator = Quaternion.identity;
                    instEmp = Instantiate(empty, objpos1, objRotator) as GameObject;

                    mc = instEmp.AddComponent<moveToCenter>();
                    mc.istrigger = true;
                    mc.speed = objSpeed;

                    x = Random.Range(-range, range);
                    y = Mathf.Sqrt(range*range - x * x);

                    objpos1.x += x;
                    objpos1.y += y;

                    instObj = Instantiate(obj, objpos1, objRotator) as GameObject;
                    mr = instObj.AddComponent<MovingRotate>();
                    mr.rotateObj = instObj;
                    mr.centerObj = instEmp;
                    mr.speed = objRoateSpeed;

                    yield return new WaitForSeconds(waveWait);
                    yield return new WaitForSeconds(waveWait);
                    break;
                case 4:
                    Vector3[] objpos;
                    objpos = new Vector3[4];
                    objpos[0] = new Vector3(0, -objvalsec.y, objvalsec.z);

                    objpos[1] = new Vector3(objvalsec.x, 0, objvalsec.z);

                    objpos[2] = new Vector3(0, objvalsec.y, objvalsec.z);

                    objpos[3] = new Vector3(-objvalsec.x, 0, objvalsec.z);

          

                    for (int i = 0; i < 4; i++)
                    {
                        objRotator = Quaternion.identity;
                        instEmp = Instantiate(empty, objpos[i], objRotator) as GameObject;

                        mc = instEmp.AddComponent<moveToCenter>();
                        mc.istrigger = true;
                        mc.speed = objSpeed;

                        x = Random.Range(-range, range);
                        y = Mathf.Sqrt(range*range - x * x);

                        objpos[i].x += x;
                        objpos[i].y += y;

                        instObj = Instantiate(objsec, objpos[i], objRotator) as GameObject;
                        mr = instObj.AddComponent<MovingRotate>();
                        mr.rotateObj = instObj;
                        mr.centerObj = instEmp;
                        mr.speed = objRoateSpeed;
                    }
                    break;
                default: waveCount = -1; break;
            }


            waveCount++;
        } while (waveCount > 0); 
     }

    // Update is called once per frame
            void Update () {
	
	}
}
