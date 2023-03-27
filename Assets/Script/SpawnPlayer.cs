using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class SpawnPlayer : NetworkBehaviour
{
        public GameObject prefab; // The prefab to spawn
        public Transform player1SpawnPoint; // The spawn point for the prefab
        public Transform player2SpawnPoint; // The spawn point for the prefab

    void Update()
    {
            // Spawn the prefab at the designated spawn point when the spacebar is pressed
        if (IsOwnedByServer)
        {
            Instantiate(prefab, player1SpawnPoint.position, Quaternion.identity);
        }
        else
        {
            Instantiate(prefab, player2SpawnPoint.position, Quaternion.identity);
        }
    }
}
