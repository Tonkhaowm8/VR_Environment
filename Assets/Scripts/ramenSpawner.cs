using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramenSpawner : MonoBehaviour
{
    public AudioSource audioSource;
    public List<GameObject> items = new List<GameObject>(); // List of items to activate
    public TMPro.TextMeshProUGUI uiObj;
    public GameObject arrowPrefab;
    public GameObject arrowInstance1; // First arrow instance
    public GameObject arrowInstance2; // Second arrow instance

    // Start is called before the first frame update
    void Start()
    {
        // Instantiate the first arrow prefab at the specified position
        arrowInstance1 = InstantiateArrow(new Vector3(5.38199997f, 0.409999996f, -1.31700003f));

        // Instantiate the second arrow prefab at the specified position
        arrowInstance2 = InstantiateArrow(new Vector3(2.22600007f, 0.400000006f, -1.58399999f));
    }

    // Update is called once per frame
    void Update()
    {
        // You can add code here to trigger activation of items periodically or based on certain conditions
    }

    // Function to instantiate arrow prefab at a given position
    GameObject InstantiateArrow(Vector3 position)
    {
        GameObject arrow = Instantiate(arrowPrefab, position, Quaternion.Euler(0, 0, 90)); // Instantiate arrow with rotation
        arrow.transform.localScale = new Vector3(10, 10, 10); // Set scale to 10 in all axes
        arrow.SetActive(false); // Initially hide the arrow
        return arrow;
    }

    public void ActivateRandomItem()
    {
        uiObj.text = "Objective: Throw Ramen at Prab";
        arrowPrefab.SetActive(false); // Initially hide the arrow
        arrowInstance1.SetActive(true);
        arrowInstance2.SetActive(true);

        // Hide the arrow
        //arrowInstance.SetActive(false);

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
            arrowInstance1.SetActive(false);
            arrowInstance2.SetActive(false);
            uiObj.text = "Objective: Go home by taxi";
            Debug.LogWarning("No inactive items in the list!");
            return;
        }

        // Choose a random index from the list of inactive indices
        int randomIndex = Random.Range(0, inactiveIndices.Count);

        // Activate the randomly chosen item
        items[inactiveIndices[randomIndex]].SetActive(true);

        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}