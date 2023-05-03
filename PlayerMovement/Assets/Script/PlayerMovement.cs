using System.Collections;
using System.Collections.Generic;
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
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Direction = new Vector3(horizontal, 0f, vertical); //hansi yone teref getdiyimizi(position olaraq) teyin edirik.
        if (Direction.magnitude > 0.01f)  //vectorumuzun deyishme sureti(vectorun uzunlugu) 0.01den boyukdurse
        {
            float TargetAngle = Mathf.Atan2(Direction.x, Direction.z) * Mathf.Rad2Deg; //hedef bucagi teyin edirik. Mathf Atan2 -180 ile 180
            //arasinda deyer verir. bunu rad2deg vuraraq radiani dereceye ceviririk.

            //donme bucagimizi teyin edirik. hansi ox uzre, hansi istiqamete, hansi derecede oldugumuzu ve donme suretimizi teyin edirik.
            Angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, TargetAngle, ref CurrentTurnAngle, SmoothTurnTime);
            transform.rotation = Quaternion.Euler(0f, Angle, 0f);
            rb.MovePosition(transform.position + (Direction.normalized * speed * Time.deltaTime));
        }
    }
}
