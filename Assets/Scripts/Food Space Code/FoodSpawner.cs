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
        GameObject a = Instantiate(astorid, spawnPoint[index].transform);

        Vector2 lookDir = -(Vector2)spawnPoint[index].transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        a.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
