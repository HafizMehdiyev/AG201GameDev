using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[ExecuteInEditMode]
public class SharedMaterial : MonoBehaviour
{
    //[SerializeField] Color color;


    private Material mat;


    void Start()
    {
        mat = GetComponent<Renderer>().sharedMaterial; //shared materiali cagirsaq ve materialin rengini deyissek ve eger
                                                       //material basqa obyektlere de atilibsa materialin rengi butun obyektlerde deyiser.
                                                       //normal material cagirsaq ve rengini deyissek, sadece materialin oldugu obyektin rengi deyiser.
        mat.color = new Color(0f,0f,0f); //materiala reng vermek.
        //mat.color = Color.red; materiala soz ile reng vermek.

        //mat.color = new Color32(128,128,128,255);//max 255, min 0
        //mat.color = new Color(1,1,1); //max 1, min 0  

    }
    private void Update()
    {
        //mat.color = color; //color bizim globalda teyin etdiyimiz fielddir(9-cu setr). 
    }

}
