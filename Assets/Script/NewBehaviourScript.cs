using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] ScoreSystem scoreSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            scoreSystem.ClientScore();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                scoreSystem.ClientScore();
            }
        }
    }
}
