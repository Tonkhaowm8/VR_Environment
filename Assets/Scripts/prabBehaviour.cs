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
            // Generate a random integer from 1 to 4
            int randomIdle = Random.Range(1, 5);

            // Set the "randomIdle" parameter in the Animator
            animator.SetInteger("randomIdle", randomIdle);

            // Wait for the animation duration
            yield return new WaitForSeconds(animationDuration);

            // Repeat the loop
        }
    }
}
