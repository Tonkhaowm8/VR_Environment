using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prabBehaviour : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;
    public float animationDuration = 1.0f; // Adjust the duration of your animation here
    private bool isDancing = false; // Flag to track if Prab is currently dancing

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AnimateRandomIdle());
    }

    IEnumerator AnimateRandomIdle()
    {
        while (true)
        {
            if (!isDancing) // Check if not dancing
            {
                // Generate a random integer from 1 to 3 (changed to 3 since we want inclusive range)
                int randomIdle = 2;

                // Set the "randomIdle" parameter in the Animator
                animator.SetInteger("randomIdle", randomIdle);
            }

            // Wait for the animation duration
            yield return new WaitForSeconds(animationDuration);
        }
    }

    // Called when the GameObject collides with another GameObject
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has a tag "ramen"
        if (collision.gameObject.CompareTag("ramen"))
        {
            // Play audioClip
            if (audioSource != null)
            {
                audioSource.Play();
            }

            // Deactivate the ramen GameObject
            collision.gameObject.SetActive(false);

            // Start dancing animation
            StartCoroutine(DanceAnimation());
        }

        // Check if the collided object is the main camera
        if (collision.gameObject.CompareTag("Player"))
        {
            // Set randomIdle to 1
            animator.SetInteger("randomIdle", 1);
        }
    }

    IEnumerator DanceAnimation()
    {
        // Set dancing flag to true
        isDancing = true;

        // Stop the current animation
        animator.SetInteger("randomIdle", 0);

        // Start the dance animation
        animator.SetBool("dance", true);

        // Wait for the dance animation to finish
        yield return new WaitForSeconds(animationDuration); // Adjust duration if needed

        // Stop the dance animation
        animator.SetBool("dance", false);

        // Set dancing flag to false
        isDancing = false;
    }
}

