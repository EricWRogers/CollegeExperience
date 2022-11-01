using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{

    public List<GameObject> spawnPoint;

    public GameObject astorid;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("SpawnPoint"))
        {
            spawnPoint.Add(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        int index = Random.Range(0, 21);
        Instantiate(astorid, spawnPoint[index].transform);
    }
}
