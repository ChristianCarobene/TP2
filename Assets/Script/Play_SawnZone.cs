using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_SawnZone : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private float timeToSpawn;
    [SerializeField] private float timeToDestroy;
    private bool spawned = false;
    private float totalTime;
    private GameObject obstacle;
    void Start()
    {
        totalTime = 0;
    }

    void Update()
    {
        totalTime += Time.deltaTime;
        if (totalTime > timeToSpawn && !spawned)
        {
            obstacle = Instantiate(obstaclePrefab, new Vector2(0, 0), Quaternion.identity);
            spawned = true;
        }

        if (totalTime > timeToDestroy)
        {
            Destroy(obstacle);
        }
    }
}
