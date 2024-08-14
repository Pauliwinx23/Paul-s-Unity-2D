using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    public GameObject obstacles;
    int index;
    public float length = 2000f;
    
    // Start is called before the first frame update
    void Start()
    {
       
        StartCoroutine(SpawnerCoroutine());
    }

    // Update is called onces per frame
    void Update()
    {
        
    }

    IEnumerator SpawnerCoroutine()
    {
        for (int i = 0; i < length; i++)
        {
            yield return new WaitForSeconds(0.6f);
            spawn();
        }
    }

    void spawn()
    {
        index = Random.Range(0, 2);
        if (index <= 0)
        {
            Instantiate(obstacles, transform.position + new Vector3(12.5f, 2.5f, 0f), transform.rotation);

        }

        else
        {
            Instantiate(obstacles, transform.position + new Vector3(12.5f, -2.5f, 0f), transform.rotation);

        }
    }
}
