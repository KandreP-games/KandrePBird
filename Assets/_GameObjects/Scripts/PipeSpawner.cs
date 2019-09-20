using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject prefabPipe;
    void Start()
    {
        InvokeRepeating("SpawnPipe", 0, 2); //Cada dos segundos llama a la función SpawnPipe
    }

    void Update()
    {
        
    }

    void SpawnPipe()
    {
        Instantiate(prefabPipe, transform);    
    }
}
