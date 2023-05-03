using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRay : MonoBehaviour
{
    Ray ray; //input
    RaycastHit hit; //output
    [SerializeField] GameObject enemy;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition); //mouse positionu ray-e veririk.

        if (Input.GetMouseButtonDown(0)) //mouse sol duymesini basdiqda
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) //mousedan raycast atsin.
            {
                Instantiate(enemy, hit.point, Quaternion.identity); //hit point dedikde, yeni mousedan gonderdiyimiz raycastin deydiyi yerde obyekt spawn etsin.
            }
        }

    }
}
