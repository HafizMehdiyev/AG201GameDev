using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
   //private float _SavedPosZ;
    public int _coin;

    void Start()
    {

        if (PlayerPrefs.HasKey("Money"))
        {
            _coin = PlayerPrefs.GetInt("Money");
            Debug.Log("Varli");
        }
        else
        {
            _coin = 0;
            Debug.Log("Kasib");
        }



        //transform.position = new Vector3(PlayerPrefs.GetFloat("PosX"), PlayerPrefs.GetFloat("PosY"), PlayerPrefs.GetFloat("PosZ"));
    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerPrefs.SetInt("Money", 15);
            _coin = PlayerPrefs.GetInt("Money");
            PlayerPrefs.SetFloat("PosX", transform.position.x);
            PlayerPrefs.SetFloat("PosY", transform.position.y);
            PlayerPrefs.SetFloat("PosZ", transform.position.z);
            PlayerPrefs.Save();
        }


        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
    }
    //private void OnApplicationQuit()
    //{
        
        //PlayerPrefs.Save();


        //float CurrentPosZ = PlayerPrefs.GetFloat("PosZ");
        //SavedPosZ = CurrentPosZ;
    //}
}
