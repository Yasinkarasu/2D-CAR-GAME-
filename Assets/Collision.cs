using UnityEngine;

public class Collision : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other) 
    {
        
        Debug.Log("Vurdun");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Bu ne?");

    }
}


