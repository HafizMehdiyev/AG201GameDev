using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Bu script(class) oyunda istirak edecek scriptimizdir.
public class ZombieMono : MonoBehaviour
{
    private Material _mat;
    public ZombieSO zombieData;
    public float speed;
    public float health;

    void Start()
    {
        Initialize();

    }

    public void Initialize()
    {
        _mat = GetComponent<Renderer>().material;
        GetComponent<Renderer>().material = zombieData.mat;
        _mat.color = zombieData.color;
        gameObject.name = zombieData.name;
        speed = zombieData.suret;
        health = zombieData.can;
    }
}
