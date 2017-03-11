using UnityEngine;
using System.Collections;

public class CircleRandCreatePlus : MonoBehaviour {

    public GameObject[] gameobj;

    public float pos;
    
    public int rate;

    private float x;
    private float y;

    private int count;
    private int score;
    private int isCreate = 0;

    private Object special;

    // Use this for initialization
    void Start () {
        count = gameobj.Length;
    }
	
	// Update is called once per frame
	void Update () {
        score = GameObject.Find("Center").GetComponent<Score>().score;
        if (score >= rate && score % rate == 0 && isCreate == 0) 
        {
            CreateSpecial();
            isCreate = 1;
        }
        if (special == null)
        {
            isCreate = 0;
        }
    }

    void CreateSpecial()
    {
        x = Random.Range(-pos, pos);
        y = Mathf.Sqrt(pos * pos - x * x);

        int fuhao = Random.Range(0, 2);
        if (fuhao == 0)
        {
            y = -y;
        }
        int type = Random.Range((int)0, count);



        Vector3 Position = new Vector3(x, y);
        Quaternion spawnRotator = Quaternion.identity;
        special=Instantiate(gameobj[type], Position, spawnRotator);
    }
}
