using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemiesSO enemies;

    private void Start()
    {
        Instantiate(enemies.zombie[0], new Vector3(1f, 12f, 1f), transform.rotation);

    }
}
