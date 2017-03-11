using UnityEngine;
using System.Collections;

public class CircleRandCreate : MonoBehaviour {


    public GameObject[] gameobj;
    public float wait;



    public float pos;
    private float x;
    private float y;
    private float _saveTime;
    private float _currentTime;
    private int count;
    // Use this for initialization
    void Start()
    {
        _saveTime = Time.time;
        _currentTime = Time.time;
        count = gameobj.Length;
    }
 
    // Update is called once per frame
    void Update()
    {
        _currentTime = Time.time;
        if(_currentTime-_saveTime> wait)
        {
            x = Random.Range(-pos, pos);
            y = Mathf.Sqrt(pos * pos - x * x);

            int fuhao = Random.Range(0, 2);
            if (fuhao== 0)
            {
                y = -y;
            }
            int type = Random.Range((int)0,count);



            Vector3 Position = new Vector3(x, y);
            Quaternion spawnRotator = Quaternion.identity;
            Instantiate(gameobj[type], Position, spawnRotator);

            _saveTime = Time.time;
        }
    }
}
