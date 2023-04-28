using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float vertical;
    float horizontal;
    [SerializeField] float posY;
    float value;
    [SerializeField] float speed;
   private bool _entered = false;

    void Update()
    {
        #region All
        //vertical = Input.GetAxis("Vertical");
        //horizontal = Input.GetAxis("Horizontal");
        //transform.position += new Vector3(horizontal, 0f, vertical) * speed * Time.deltaTime; //x(horizontal) y z(vertical)
        //transform.position = new Vector3(value, transform.position.y,transform.position.z);
        //posX = Mathf.Clamp(transform.position.x, -4.5f, 4.50f);
        //posY = Mathf.Clamp(transform.position.y, -4.5f, 4.50f);
        //transform.position = new Vector3(transform.position.x+15f,transform.position.y,transform.position.z);
        #endregion
        //16-ci setrdeki regionda Clamp var
        //Mathf.Clamp, verdiyimiz deyeri hedef deyere qeder yukselder ve ya azaldar.
        //value = Mathf.Lerp(value, 15f, 0.02f); ////value deyerini value-nun oldugu deyerden 15-e qeder artirar. 
        //value = Mathf.Ceil(); ////verdiyimiz deyeri tam edede yuxari yukselder.


    }
     
}
