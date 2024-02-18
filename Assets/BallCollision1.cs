using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public AudioClip[] collisionSounds; // Array to hold the collision audio clips
    private bool hasCollided = false;   // Flag to track if collision has occurred

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if colliding with an object tagged as "block" and if collision hasn't occurred yet
        if (collision.gameObject.CompareTag("block"))
        {
            // Play a random audio clip from the collisionSounds array
            if (collisionSounds.Length > 0)
            {
                int randomIndex = Random.Range(0, collisionSounds.Length);
                AudioSource.PlayClipAtPoint(collisionSounds[randomIndex], transform.position);
            }

            // Set the flag to true to prevent playing the sound again on subsequent collisions
            //hasCollided = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // Check if colliding with an object tagged as "block" and if collision hasn't occurred yet
        if (collider.gameObject.CompareTag("death"))
        {
            // Play a random audio clip from the collisionSounds array
            if (collisionSounds.Length > 0)
            {
                int randomIndex = Random.Range(0, collisionSounds.Length);
                AudioSource.PlayClipAtPoint(collisionSounds[randomIndex], transform.position);
            }

            // Set the flag to true to prevent playing the sound again on subsequent collisions
            //hasCollided = true;
        }
    }
}

