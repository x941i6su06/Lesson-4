using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab;
    private float spawnRange = 9;
    void Start()
    {
        
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    }
    private Vector3 GenerateSpawnPosition(){
        float spawnPosX=Random.Range(-spawnRange,spawnRange);
        float spawnPosZ=Random.Range(-spawnRange,spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX,0,spawnPosZ);
        return randomPos;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
