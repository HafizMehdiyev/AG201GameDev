using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    bool Wall90Move = false;
    [SerializeField] float speed;
    Rigidbody rb;

    private void Awake()
    {

        if (instance == null)
            instance = this;
        rb = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Next"))
        {
            other.gameObject.SetActive(false);
            SceneManagerController.instance.NextLevel(gameObject);
        }

    }
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");


        if (Input.GetKey(KeyCode.E))
        {
            transform.rotation *= Quaternion.Euler(0f,2f,0f);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.rotation *= Quaternion.Euler(0f, -2f, 0f);
        }
        if (Wall90Move)
        {
            transform.localPosition += new Vector3(horizontal, vertical, 0f) * speed * Time.deltaTime;
            rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationZ;
        }
        else
        {
            //transform.localPosition += new Vector3(horizontal, 0f, vertical) * speed * Time.deltaTime;
            transform.Translate(new Vector3(horizontal,0f,vertical) * Time.deltaTime * speed,Space.Self);

            rb.constraints = RigidbodyConstraints.None;
        }
    }

    public void ChangeMode()
    {
        Wall90Move = !Wall90Move;
    }

}
