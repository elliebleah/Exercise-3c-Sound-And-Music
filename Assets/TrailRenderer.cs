using UnityEngine;

public class TrailController : MonoBehaviour
{
    private TrailRenderer trailRenderer;
    public SpriteRenderer spriteRenderer;
    void Start()
    {
        // Get the TrailRenderer component attached to the object
        trailRenderer = GetComponent<TrailRenderer>();
        // Disable the trail initially
        trailRenderer.enabled = true;

        // Load the material with the object's sprite
        if (spriteRenderer != null && spriteRenderer.sprite != null)
        {
            Material trailMaterial = new Material(Shader.Find("Sprites/Default"));
            trailMaterial.mainTexture = spriteRenderer.sprite.texture;
            trailRenderer.material = trailMaterial;
        }
        else
        {
            Debug.LogWarning("No SpriteRenderer or sprite found on the object.");
        }
    }

    void Update()
    {
       
    }
}
