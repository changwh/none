using UnityEngine;
using System.Collections;
using System;

public class WorldToScreen : MonoBehaviour {
    private Vector2 screenpos;
    private float distance;
    // Use this for initialization
    void Start () {
        GameObject gamecontrol = GameObject.Find("GAMECONTROL");
        //GameControl.list.Add(this);
    }
    // Update is called once per frame
    void Update () {
    screenpos = Camera.main.WorldToScreenPoint(transform.position);
        
    }
    void OnDestory()
    {
        //GameControl.list.Remove(this);
    }

    public Vector2 getscreenpos()
    {
        return screenpos;
    }
    public void setdistance(float dis)
    { distance = dis; }
    public float getdistance()
    { return distance; }
}
