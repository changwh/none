using UnityEngine;
using System.Collections;

public class DampMove : MonoBehaviour {

    public float _time = 5;
    private float _saveTime;

    [Header("阻尼运动")]
    public float 阻尼振幅 = 3;
    public float 阻尼衰减度 = 1.4f;
    public float 阻尼频率 = 3;


    // Use this for initialization
    void Start()
    {
        _saveTime = Time.time;
    }
    void Update()
    {
        transform.localPosition = CurveEquation.Damping(nowTime * _time, 阻尼振幅, 阻尼衰减度, 阻尼频率);
        //transform.position = CurveEquation.Damping(nowTime * _time, 阻尼振幅, 阻尼衰减度, 阻尼频率);
    }

    protected float nowTime
    {
        get
        {
            float t1 = Time.time - _saveTime;
            float t2 = 0;
            t2 = t1 / _time;
            return t2;
        }
    }

}
