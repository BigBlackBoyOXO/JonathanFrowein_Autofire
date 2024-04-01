using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacment : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust speed as needed

    void Update()
    {
        // Input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Movement
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);


    }
}