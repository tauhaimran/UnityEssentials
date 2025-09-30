using UnityEngine;
using System.Collections;

// Represents a collectible item in the game.

public class Collectible : MonoBehaviour
{
    public float rotationSpeed = 0.50f; // Speed of rotation for visual effect.
                                        // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject collectibleEffect; // Effect to play when collected.

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0); // Rotate the collectible for a visual effect.
    }
    
    private void OnTriggerEnter(Collider other) //wohooo a commentt
    {
        if (other.CompareTag("Player"))
        {
            // Logic for when the player collects the item.
            //Debug.Log("Collectible picked up!");
            Destroy(gameObject); // Remove the collectible from the scene.

            //instantiate the collectible effect at the collectible's position and rotation
            Instantiate(collectibleEffect, transform.position, transform.rotation);
        }
    }
}
