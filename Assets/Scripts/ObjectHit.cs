using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer meshRenderer;
    
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Player")
        {
            meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material.color = Color.yellow;
            gameObject.tag = "Hit";
        }
        
    }
}
