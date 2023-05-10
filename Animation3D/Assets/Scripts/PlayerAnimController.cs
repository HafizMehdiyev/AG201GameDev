using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    public bool kec;
    [SerializeField] Animator anim; //Obyekte atdigimiz animator komponentini teyin edirik(hansi ki o animator komponentine animator controller vermishik)
    void Start()
    {
        anim = GetComponent<Animator>();

    }
    private void Update()
    {
        if (kec) 
        {
            anim.SetBool("kec",true); //animator controllere teyin etdiyimiz bool parametrinin deyerini true edirik.
        }
    }

}
