using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SehneManager : MonoBehaviour
{
    public int level = 0;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}


