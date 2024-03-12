using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomAnimation : MonoBehaviour
{
    // Reference to the animator component
    public Animator anim;
    // Reference to the audio source component
    public AudioSource audioSource;
    // Audio clip to play
    public AudioClip soundClip;

    // Start is called before the first frame update
    void Start()
    {
        // Get the animator component attached to the same GameObject
        //anim = GetComponent<Animator>();

        // Generate a random number between 1 and 3
        int randomAnimationNumber = Random.Range(1, 3); // The second parameter is exclusive

        // Set the random number to the integer parameter "randomIdle"
        anim.SetInteger("randomIdle", randomAnimationNumber);
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider is tagged as "Player"
        if (other.CompareTag("Player"))
        {
            Debug.Log("Hello");

            int randomAnimationNumber = 4;

            // Set the random number to the integer parameter "randomIdle"
            anim.SetInteger("randomIdle", randomAnimationNumber);

            // Check if an audio clip is assigned
            if (soundClip != null && audioSource != null)
            {
                // Play the audio clip once
                audioSource.PlayOneShot(soundClip);
            }
        }
    }

    // OnTriggerExit is called when the Collider other exits the trigger
    private void OnTriggerExit(Collider other)
    {
        // Check if the collider is tagged as "Player"
        if (other.CompareTag("Player"))
        {
            int randomAnimationNumber = 1;

            // Set the random number to the integer parameter "randomIdle"
            anim.SetInteger("randomIdle", randomAnimationNumber);
        }
    }
}