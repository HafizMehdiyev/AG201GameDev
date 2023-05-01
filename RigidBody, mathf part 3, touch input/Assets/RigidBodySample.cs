using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RigidBodySample : MonoBehaviour
{

    public float maxSpeed=10f;
    public float speed;
    private Rigidbody _rb;
    float vertical;
    float horizontal;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {


        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");


        _rb.AddForce(new Vector3(0f, 0f, vertical) * speed, ForceMode.Impulse); //hereket etdiren kodumuzdur. Obyektimize
        // z istiqametinde quvvet tetbiq edir. vertical deyerini input ile gotururuk. 
        //burada forcemode impulse ile bizim tetbiq etdiyimiz quvvemizin hansi terzde olacagini veririk.
        if (_rb.velocity.magnitude > maxSpeed) //eger ki obyektimizin sureti(tecili) bizim teyin etdiyimiz
            //maksimum suret limitini asibsa, onda:
        {
            //oyun obyektimizin suretini(tecilini) maxSpeed deyeri ile limitleyirik.
            _rb.velocity = Vector3.ClampMagnitude(_rb.velocity, maxSpeed);

        }
    }


}
