using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class BouncingOffTheWall : NetworkBehaviour
{
    [SerializeField] ScoreSystem scoreSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            scoreSystem.HostScore();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                scoreSystem.HostScore();
            }
        }
    }
}

