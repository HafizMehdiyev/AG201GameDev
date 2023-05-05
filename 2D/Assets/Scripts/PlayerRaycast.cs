using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    RaycastHit hit;
    public float distance;
    public LayerMask layer;
    void Start()
    {
        
    }

    void Update()
    {
        if (Physics2D.Raycast(transform.position,transform.right, distance,layer))
        {
            Debug.Log("AAAAAAAAAAA");
        }
        Debug.DrawRay(transform.position,transform.right*distance);
    }
}
