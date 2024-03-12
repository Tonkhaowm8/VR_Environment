using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prabBehaviour : MonoBehaviour
{
    public Animator animator;
    public float animationDuration = 1.0f; // Adjust the duration of your animation here

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AnimateRandomIdle());
    }

    IEnumerator AnimateRandomIdle()
    {
        while (true)
        {
            // Generate a random integer from 1 to 3
            int randomIdle = Random.Range(1, 4);

            // Set the "randomIdle" parameter in the Animator
            animator.SetInteger("randomIdle", randomIdle);

            // Wait for the animation duration
            yield return new WaitForSeconds(animationDuration);
        }
    }

    // Called when another Collider enters the trigger
    void OnTriggerEnter(Collider other)
    {
        // Check if the other collider has the tag "ramen"
        if (other.CompareTag("ramen"))
        {
            // Set randomIdle to 4
            animator.SetInteger("randomIdle", 4);
        }
    }
}
