using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawn : MonoBehaviour
{


    public GameObject[] fruits;

    void Start()
    {

        InvokeRepeating("Spawn", 1.0f, 0.7f);
    }


    void Update()
    {

    }

    private void Spawn()
    {
        GameObject donutBase = Instantiate(fruits[(Random.Range(0, 4))], transform.position, Quaternion.identity);
    }

}
