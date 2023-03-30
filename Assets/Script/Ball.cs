using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Transform teleportPosition;
    [SerializeField] private float bounceForce;

    [SerializeField] private Rigidbody rb;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Goal"))
        {
            transform.position = teleportPosition.position;
            rb.velocity = Vector3.zero;

        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 normal = collision.contacts[0].normal;
            Vector3 bounceDirection = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f)).normalized;
            Vector3 newDirection = Vector3.Reflect(transform.forward, normal) + bounceDirection;

            // Apply the bounce force in the new direction
            rb.velocity = Vector3.zero;
            rb.AddForce(newDirection * bounceForce, ForceMode.Impulse);
            Debug.Log("Hit the player");
        }
        // add force in a direct5ion away from the colliding object
    }
}
