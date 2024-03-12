using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowBehaviour : MonoBehaviour
{
    public float speed = 2f; // Speed of the up and down motion
    public float amplitude = 1f; // Amount of vertical motion

    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the vertical offset based on time
        float yOffset = Mathf.Sin(Time.time * speed) * amplitude;

        // Set the new position
        transform.position = startPos + new Vector3(0, yOffset, 0);
    }
}

