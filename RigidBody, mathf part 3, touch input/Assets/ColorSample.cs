using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSample : MonoBehaviour
{
    [SerializeField] Color color;
    [SerializeField] Material material;
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    void Update()
    {
        material.color = Color.Lerp(material.color, Color.red, 0.1f); //obyektin rengini zamanla deyisher.
    }
}
