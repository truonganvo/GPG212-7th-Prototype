using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class TopDownMovement : NetworkBehaviour
{
    // Declare variables for character movement
    [SerializeField] private float speed = 5f;
    [SerializeField] private GameObject ownPrefab;
    private Vector3 moveDirection;

    private void Start()
    {
        GetComponent<Rigidbody>().freezeRotation = true;
    }

    void Update()
    {
        if (!IsOwner || !Application.isFocused) return;

        // Get input from the player
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Calculate the move direction based on input
        moveDirection = new Vector3(horizontal, 0f, vertical).normalized;
        moveDirection *= speed;

        // Move the character controller
        transform.Translate(moveDirection * Time.deltaTime);

        if (IsOwnedByServer)
        {
            ownPrefab.GetComponent<Renderer>().material.color = Color.blue;
        }
        else
        {
            ownPrefab.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
