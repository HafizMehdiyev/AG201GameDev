using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QualityLevel : MonoBehaviour
{
    
    public void SetQualityLevel(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }

}
