using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawninimigo : MonoBehaviour
{
    
    public Transform enemySpawn;
    public GameObject enemyPrefab;
    public float tempSpawn;
    public float cronometro;

    void Start()
    {
    }
    void Update()
    {
        cronometro+=Time.deltaTime;
        if(cronometro >= tempSpawn){
            Instantiate(enemyPrefab, enemySpawn.position, enemySpawn.rotation);
            cronometro=0;
        }
    }

}
