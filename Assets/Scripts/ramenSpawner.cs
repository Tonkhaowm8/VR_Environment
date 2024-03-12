using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramenSpawner : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>(); // List of items to activate

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // You can add code here to trigger activation of items periodically or based on certain conditions
    }

    public void ActivateRandomItem()
    {
        if (items.Count == 0)
        {
            Debug.LogWarning("No items in the list!");
            return;
        }

        // Create a list to store indices of items that are inactive
        List<int> inactiveIndices = new List<int>();

        // Find indices of items that are inactive
        for (int i = 0; i < items.Count; i++)
        {
            if (!items[i].activeSelf)
            {
                inactiveIndices.Add(i);
            }
        }

        // If no inactive items found, log a warning and return
        if (inactiveIndices.Count == 0)
        {
            Debug.LogWarning("No inactive items in the list!");
            return;
        }

        // Choose a random index from the list of inactive indices
        int randomIndex = Random.Range(0, inactiveIndices.Count);

        // Activate the randomly chosen item
        items[inactiveIndices[randomIndex]].SetActive(true);
    }
}