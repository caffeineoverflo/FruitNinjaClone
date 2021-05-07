using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fruitToSpawnPrefab;
    public Transform[] spawnPlaces;
    public float minwait = 0.3f;
    public float maxWait = 1f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFriuts());
    }

    private IEnumerator SpawnFriuts()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(minwait, maxWait));

            GameObject fruit = Instantiate(fruitToSpawnPrefab, transform.position, transform.rotation);

            //Debug.Log("Frucht wurde erzeugt!");
        }
    }
}
