using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CASP.SoundManager;

public class SoundManagerSample : MonoBehaviour
{
    void Start()
    {
        SoundManager.instance.Play("BounceEffekt", true);

    }


}
