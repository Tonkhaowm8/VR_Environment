using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramen : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component
    private Vector3 originalPosition; // Original position of the GameObject

    void Start()
    {
        // Store the original position when the GameObject is initialized
        originalPosition = transform.position;
    }

    // Called when the GameObject collides with another GameObject
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has a tag "floor"
        if (collision.gameObject.CompareTag("floor"))
        {
            // Check if the audio source is not null and if it is not already playing
            if (audioSource != null && !audioSource.isPlaying)
            {
                // Play the audio source
                audioSource.Play();
            }

            // Set the GameObject's active state to false
            gameObject.SetActive(false);
        }
    }

    // Called when the GameObject is disabled
    void OnDisable()
    {
        // Reset the position of the GameObject to its original position
        transform.position = originalPosition;
    }
}
