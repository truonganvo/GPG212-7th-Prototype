using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using Unity.VisualScripting;

public class Kick : NetworkBehaviour
{
    public float radius = 5f; // Radius around object to check for balls
    public float force = 10f; // Force to apply to ball

    public Color radiusColor = Color.yellow; // Color of the radius visualization

    private NetworkManager findBall;

    private void Start()
    {
        findBall = FindObjectOfType<NetworkManager>();
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = radiusColor;
        Gizmos.DrawWireSphere(transform.position, radius); // Draw wire sphere around object with radius
    }

    //void Update()
    //{
    //    Collider[] colliders = Physics.OverlapSphere(transform.position, radius); // Get all colliders within radius
    //    if (IsOwnedByServer)
    //    {
    //        //isOwner= true;
    //        Debug.Log("Host Joined");
    //        foreach (Collider collider in colliders)
    //        {
    //            if (collider.gameObject.CompareTag("Ball") && Input.GetKeyDown(KeyCode.Space))
    //            { // Check if collider is a ball and space key is pressed
    //                Debug.Log("Host kick the ball");
    //                Rigidbody rb = collider.gameObject.GetComponent<Rigidbody>(); // Get ball's rigidbody
    //                rb.AddForce(transform.right * force, ForceMode.Impulse); // Apply force to ball
    //            }
    //        }
    //    }
    //    else
    //    {
    //        Debug.Log("Client Joined");
    //        foreach (Collider collider in colliders)
    //        {
    //            if (collider.gameObject.CompareTag("Ball") && Input.GetKeyDown(KeyCode.Space))
    //            { // Check if collider is a ball and space key is pressed
    //                Debug.Log("Client kick the ball");
    //                //SetVelocityClientRpc(collider.gameObject, -transform.right * force);

    //                //Rigidbody rb = collider.gameObject.GetComponent<Rigidbody>(); // Get ball's rigidbody
    //                //NetworkManager.Singleton.SpawnManager.SpawnedObjects<>
    //                // 1 - Loop through the network manager spawn object to find ball
    //                // 2 - Tell the network manager to move/add force to the ball
    //                //rb.AddForce(-transform.right * force, ForceMode.Impulse); // Apply force to ball
    //            }
    //        }
    //    }


    //}

    //[ClientRpc]
    //void SetVelocityClientRpc(Vector2 velocity)
    //{
    //    if (!IsHost)
    //    {
    //        Rigidbody rb = collider.gameObject.GetComponent<Rigidbody>(); // Get ball's rigidbody
    //        rb.AddForce(-transform.right * force, ForceMode.Impulse); // Apply force to ball
    //    }

    //}
}

