using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class SpawnPlayer : NetworkBehaviour
{
        public GameObject prefab; // The prefab to spawn
        public Transform ballSpawnPoint; // The spawn point for the prefab

    private void Start()
    {
        Instantiate(prefab, ballSpawnPoint.position, Quaternion.identity);
    }
}
