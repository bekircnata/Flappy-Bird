using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;

    [SerializeField] private float spawnInterval = 2f;
    [SerializeField] private float minHeight = -0.2f;
    [SerializeField] private float maxHeight = 0.7f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnPipe), 1f, spawnInterval);
    }

    void SpawnPipe()
    {
        Vector3 spawnPosition = new Vector3(0, Random.Range(minHeight, maxHeight));
        GameObject newPipe = Instantiate(pipePrefab, spawnPosition, Quaternion.identity);

        Destroy(newPipe, 10f);

    }
}
