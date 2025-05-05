using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashInBin : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bin")
        {
            // Debug.Log("Good job!");
            // gameObject.SetActive(false);
            Destroy(gameObject);
            
        }

    }
    
}
