using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class PlayerMovement : MonoBehaviour
{

    private float horizontal;
    private float vertical;
    Rigidbody2D _rb;
    [SerializeField] float speed;
    Vector2 _direction;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");


        _direction = new Vector2(horizontal, vertical);
        if (_direction.magnitude > 0.01f) 
        {
            _rb.velocity = _direction.normalized * speed;
        }

        
    }
    public void FreezeRB()
    {
    }
}
