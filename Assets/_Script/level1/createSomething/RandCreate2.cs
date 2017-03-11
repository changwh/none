using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandCreate2 : MonoBehaviour
{

    public GameObject sphere;
    public Vector3 spawnValues;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public int sphereCount;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnWaves());
    }
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < sphereCount; i++)
            {
                Vector3 spawnPosition = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
                Quaternion spawnRotator = Quaternion.identity;
                Instantiate(sphere, spawnPosition, spawnRotator);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
		
}