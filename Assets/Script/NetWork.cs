using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using Unity.Networking.Transport;
using static UnityEditor.Experimental.GraphView.GraphView;

public class NetWork : NetworkBehaviour
{
    public GameObject prefab; // The prefab to spawn
    public Transform hostSpawnPoint; // The spawn point for the prefab
    public Transform clientSpawnPoint; // The spawn point for the prefab
    public void StartServer()
    {
        NetworkManager.Singleton.StartServer();
        Instantiate(prefab, hostSpawnPoint.position, Quaternion.identity);
    }

    public void StartHost()
    {
        NetworkManager.Singleton.StartHost();
    }

    public void StartClient()
    {
        NetworkManager.Singleton.StartClient();
        Instantiate(prefab, clientSpawnPoint.position, Quaternion.identity);
    }
}
