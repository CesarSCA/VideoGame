using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CañonDisparo : MonoBehaviour
{

    public GameObject bala;
    public float intervalo = 3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBullet", 1f, intervalo);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SpawnBullet()
    {
        Instantiate(bala, transform);
    }
}
