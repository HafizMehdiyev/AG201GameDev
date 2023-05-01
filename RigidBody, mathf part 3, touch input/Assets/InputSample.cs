using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputSample : MonoBehaviour
{
    private void Update()
    {
        if(Input.touchCount > 0) //barmaq toxunushunun 0dan boyuk oldugunu, yeni toxunusun oldugunu yoxlayiriq.f
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began) //getKeyUp-a oxsayir, toxunmaga basladigimiz an ise dusur.
                Debug.Log("Toxunuldu");
            if (Input.GetTouch(0).phase == TouchPhase.Ended) //elimizi ekrandan chekdikde ended ishleyir.GetKeyUp kimidir.
                Debug.Log("Toxunma bitdi");
            if (Input.GetTouch(0).phase == TouchPhase.Canceled) // oyunda yaranan her hansisa xeta neticesinde toxundugumuzdan sonra
                // input kesilirse canceled ise dusur.
                Debug.Log("canceled");
            if (Input.GetTouch(0).phase == TouchPhase.Moved)// toxundugdan sonra elimizi ekrandan cekmeden 
                //elimizi surusdururukse moved ise dusur.
                Debug.Log("Hereket etdirilir");
        }
    }


}
