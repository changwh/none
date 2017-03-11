using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {

    public AudioSource soundOfDestroy;

    void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Cylinder"))
        {
            Debug.Log("collider" + collider.name);
            Destroy(collider.gameObject);
            soundOfDestroy.Play();
            collider.GetComponent<ScoreOfObject>().AddScore();
        }
    }

}
