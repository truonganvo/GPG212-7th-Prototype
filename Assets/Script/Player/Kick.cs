using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class Kick : NetworkBehaviour
{
    public float radius = 5f; // Radius around object to check for balls
    public float force = 10f; // Force to apply to ball
    void Update()
    {

        if (IsOwnedByServer)
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, radius); // Get all colliders within radius
            foreach (Collider collider in colliders)
            {
                if (collider.gameObject.CompareTag("Ball") && Input.GetKeyDown(KeyCode.Space))
                { // Check if collider is a ball and space key is pressed
                    Rigidbody rb = collider.gameObject.GetComponent<Rigidbody>(); // Get ball's rigidbody
                    rb.AddForce(transform.right * force, ForceMode.Impulse); // Apply force to ball
                }

            }
        }
        else if (!IsOwnedByServer) 
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, radius); // Get all colliders within radius
            foreach (Collider collider in colliders)
            {
                if (collider.gameObject.CompareTag("Ball") && Input.GetKeyDown(KeyCode.Space))
                { // Check if collider is a ball and space key is pressed
                    Rigidbody rb = collider.gameObject.GetComponent<Rigidbody>(); // Get ball's rigidbody
                    rb.AddForce(-transform.right * force, ForceMode.Impulse); // Apply force to ball
                }

            }
        }
    }
}