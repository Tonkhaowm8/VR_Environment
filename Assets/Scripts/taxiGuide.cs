using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taxiGuide : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>(); // List of items to activate
    public TMPro.TextMeshProUGUI uiObj;
    public GameObject arrowPrefab;
    private GameObject arrowInstance; // Arrow instance

    // Start is called before the first frame update
    void Start()
    {
        // Instantiate the arrow prefab at the starting position (you may choose another position if needed)
        arrowInstance = Instantiate(arrowPrefab, Vector3.zero, Quaternion.identity);
        arrowInstance.SetActive(false); // Initially hide the arrow
    }

    // Update is called once per frame
    void Update()
    {
        // You can add code here to trigger activation of items periodically or based on certain conditions
    }

    public void GuideToTaxi()
    {
        uiObj.text = "Objective: Tap taxi to go home";

        // Set the position and rotation of the arrow instance
        arrowInstance.transform.position = new Vector3(-14.2320004f, 1.25300002f, 7.12099981f);
        arrowInstance.transform.rotation = Quaternion.Euler(0, 90, 90);

        // Show the arrow
        arrowInstance.SetActive(true);
    }
}
