using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class BouncingOffTheWall : NetworkBehaviour
{
    [SerializeField] ScoreSystem scoreSystem;
    [SerializeField] Transform teleportPosition;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            scoreSystem.HostScore();
            other.transform.position = teleportPosition.position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                scoreSystem.HostScore();
                collision.transform.position = teleportPosition.position;
            }
        }
    }
}

