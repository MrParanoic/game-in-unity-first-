using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnenySpawner : MonoBehaviour
{
    [SerializeField] private Transform[] SpawnPoint;
    [SerializeField] private GameObject prefabEnemy;

    private void Start()
    {
        for (int i = 0; i < SpawnPoint.Length; i++)
        {
            Instantiate(prefabEnemy, SpawnPoint[i]);
        }
    }

}
