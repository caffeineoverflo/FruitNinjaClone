using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject slicedFruitPrefab;

    public void CreateSlicedFruit() 
    {
        GameObject inst = Instantiate(slicedFruitPrefab, transform.position, transform.rotation);

        Rigidbody[] rbOnSliced = inst.transform.GetComponentsInChildren<Rigidbody>();

        foreach(Rigidbody r in rbOnSliced) 
        {
            r.transform.rotation = Random.rotation; // bestimmt Position und Rotation 
            r.AddExplosionForce(Random.Range(500,1000), transform.position, 5f); // fügt Kraft / Explosion hinzu 
        }

        Destroy(gameObject); // zerstört die Frucht
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) // erzeugt eine geslicede Frucht wenn Space gedrückt wird
        {
            CreateSlicedFruit();
        }
        
    }
}
