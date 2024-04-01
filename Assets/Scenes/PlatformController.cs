using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public Color activatedColor = Color.green;
    private Renderer platformRenderer;

    void Start()
    {
        platformRenderer = GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            platformRenderer.material.color = activatedColor;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            platformRenderer.material.color = Color.red; // Change back to red when player exits
    }
}

