using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Delivery : MonoBehaviour
{
    
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] float destroyDelay = 0.5f;

    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    bool hasPackage;

    void OnCollisionEnter2D(Collision2D other) 
    {
        
        Debug.Log("Vurdun");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package" && !hasPackage)
        {
             Debug.Log("Package picked up");
             hasPackage = true;
             spriteRenderer.color = hasPackageColor; 
             Destroy(other.gameObject, destroyDelay);
        }   

        if (other.tag == "Customer" && hasPackage )
        {
            Debug.Log("Package Delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }

}
