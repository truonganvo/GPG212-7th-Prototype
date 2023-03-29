using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] ScoreSystem scoreSystem;
    [SerializeField] Transform teleportPosition;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            scoreSystem.ClientScore();
            other.transform.position = teleportPosition.position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                scoreSystem.ClientScore();
                collision.transform.position = teleportPosition.position;
            }
        }
    }
}
