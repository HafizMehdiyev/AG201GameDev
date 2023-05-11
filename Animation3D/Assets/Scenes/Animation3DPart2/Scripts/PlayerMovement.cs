using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class PlayerMovement : MonoBehaviour
{

    float horizontal;
    float vertical;
    Vector3 Direction;
    float CurrentTurnAngle;
    float SmoothTurnTime = 0.04f;
    public float speed;
    float Angle;
    Rigidbody rb;
    private Animator _animator;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))    
        {
            _animator.SetBool("Jump",true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _animator.SetBool("Jump",false);

        }
    }

    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Direction = new Vector3(horizontal, 0f, vertical);


        if (Direction.magnitude > 0.01f)
        {
            float TargetAngle = Mathf.Atan2(Direction.x, Direction.z) * Mathf.Rad2Deg;
            Angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, TargetAngle, ref CurrentTurnAngle, SmoothTurnTime);
            transform.rotation = Quaternion.Euler(0f, Angle, 0f);
            rb.MovePosition(transform.position + (Direction.normalized * speed * Time.deltaTime));
            _animator.SetBool("Jogging",false);
            _animator.SetFloat("Walk", Direction.magnitude);
            speed = 1.5f;
        }


        if (Direction.magnitude > 0.5f)
        {
            speed = 3;
            _animator.SetBool("Jogging",true);
            _animator.SetFloat("Walk", Direction.magnitude);
        }
        else
        {
            speed = 1.5f;
            _animator.SetBool("Jogging", false);
            _animator.SetFloat("Walk", Direction.magnitude);
        }

    }
}
