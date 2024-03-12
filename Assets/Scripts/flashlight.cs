using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    public GameObject flashlightObject; // Reference to the flashlight GameObject
    public AudioSource audioSource; // Reference to the AudioSource component for the toggle sound

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the flashlight to be inactive
        flashlightObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the 'N' key is pressed
        if (Input.GetKeyDown(KeyCode.N))
        {
            // Toggle the active state of the flashlight
            flashlightObject.SetActive(!flashlightObject.activeSelf);

            // Play audio clip
            if (audioSource != null)
            {
                audioSource.Play();
            }
        }
    }
}

