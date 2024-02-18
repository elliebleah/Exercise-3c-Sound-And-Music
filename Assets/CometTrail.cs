using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometTrail : MonoBehaviour
{
    public GameObject trailPrefab;     // Prefab of the sprite for the comet trail
    public int trailLength = 10;       // Maximum length of the comet trail
    public float trailSpacing = 0.1f;  // Spacing between each sprite in the trail
    private GameObject[] trailSprites; // Array to hold the comet trail sprites
    private int currentIndex = 0;      // Index to keep track of the current position in the trail

    void Start()
    {
        // Initialize the array to hold the comet trail sprites
        trailSprites = new GameObject[trailLength];

        // Instantiate the comet trail sprites
        for (int i = 0; i < trailLength; i++)
        {
            trailSprites[i] = Instantiate(trailPrefab, transform.position, Quaternion.identity);
            trailSprites[i].SetActive(false);
        }
    }

    void Update()
    {
        // Update the position of each sprite in the trail
        for (int i = 0; i < trailLength; i++)
        {
            if (trailSprites[i].activeSelf)
            {
                trailSprites[i].transform.position = Vector2.Lerp(trailSprites[i].transform.position, transform.position, 0.5f);
            }
        }

        // Activate the next sprite in the trail
        if (!trailSprites[currentIndex].activeSelf)
        {
            trailSprites[currentIndex].SetActive(true);
        }

        // Increment the index and wrap around if necessary
        currentIndex = (currentIndex + 1) % trailLength;
    }
}

