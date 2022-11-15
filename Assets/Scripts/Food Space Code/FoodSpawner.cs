using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{

    public List<GameObject> spawnPoint;
    public List<Sprite> sprites;

    public GameObject astroid;
    
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
        GameObject temp = Instantiate(astroid, spawnPoint[index].transform);
        temp.GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Count - 1)];

        Vector2 lookDir = -(Vector2)spawnPoint[index].transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        temp.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
