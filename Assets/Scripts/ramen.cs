using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramen : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

    }

    // Called when the GameObject collides with another GameObject
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has a tag "floor"
        if (collision.gameObject.CompareTag("floor"))
        {
            // Set the GameObject's active state to false
            gameObject.SetActive(false);
        }
    }
}
