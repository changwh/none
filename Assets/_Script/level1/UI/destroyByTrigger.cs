using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class destroyByTrigger : MonoBehaviour {
    public float hp;
    public Image bloodbar;
    Color c;
    public AudioSource hurt;
    public AudioSource destroy;
	// Use this for initialization
	void Start () {
        c = bloodbar.color;
    }
	
	// Update is called once per frame
	void Update () {
        if (hp<100)
        {
            c.a -= 0.25f / 100 * Time.timeScale;
            hp += 0.25f;
        }
        bloodbar.color = c;
	}
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        destroy.Play();
        if (hp > 0)
        {
            hp -= 50.0f;
            hurt.Play();
            Debug.Log(bloodbar.color.a);
            //bloodbar.color.a++;
            c.a += 50.0f / 100;
        }
        if (hp < 0)
        {
            Application.LoadLevel(0);
        }
    }
}
