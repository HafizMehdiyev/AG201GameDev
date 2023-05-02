using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] //SpringSample scriptinin atildigi obyektde rigidbody komponentini teleb edir.
[RequireComponent(typeof(SpringJoint))]



public class springSample : MonoBehaviour
{

    public SpringJoint sj;
    void Start()
    {
        sj = GetComponent<SpringJoint>();
    }

    private void Update()
    {
        #region Movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontal, 0f, vertical) * 15f * Time.deltaTime;
        #endregion
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>() == null) //eger bize deyen obyektin rigidbodysi yoxdursa rb elave etsin.
        {
            collision.gameObject.AddComponent<Rigidbody>();
        }

        if(collision.gameObject.GetComponent<Rigidbody>() != null) //Eger rigidbodysi varsa onda rigidbodyleri birlesdirsin.
        {
            sj.connectedBody = collision.rigidbody;
        }
    }

}

