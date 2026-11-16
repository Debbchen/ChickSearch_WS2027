using UnityEngine;

public class PickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("PickUp: OntriggerEnter: " + other.name);

        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);  
        }

        
    }

}
