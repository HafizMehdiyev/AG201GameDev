using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float distance;
    public LayerMask layer;
    public Collider[] colliders;
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        #region Movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontal, 0f, vertical) * 15f * Time.deltaTime;
        #endregion
        #region Raycast
        //RaycastHit hitInfo; //Raycast yaradiriq. buradaki hitInfo raycastin deydiyi obyektin melumatlarini saxlayir.
        
        
        //if (Physics.Raycast(transform.position, transform.forward,out hitInfo,distance,layer))
        //{
        //deydiyi obyektin adini yazdiririq.
        //    Debug.Log(hitInfo.transform.gameObject.name);
        //}
        //Debug.DrawRay(transform.position,new Vector3(0f,0f,distance),Color.red);
        #endregion

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            //overlapsphere eyni raycast kimidir. Sadece kure formasindadir.
            colliders = Physics.OverlapSphere(transform.position, distance, layer);
            StartCoroutine(Bomb());
        }
    }

    IEnumerator Bomb()
    {
        yield return new WaitForSeconds(2f);
        foreach (Collider collider in colliders)
        {
            collider.gameObject.AddComponent<Rigidbody>();
            Rigidbody rb = collider.gameObject.GetComponent<Rigidbody>();
            rb.AddExplosionForce(250f, transform.position, distance * 2f);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color32(128, 128, 128, 70);
        Gizmos.DrawSphere(transform.position, distance);
    }


}
