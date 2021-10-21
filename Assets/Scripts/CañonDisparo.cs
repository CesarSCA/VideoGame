using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CañonDisparo : MonoBehaviour
{

    public GameObject bala;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarBala", 1f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GenerarBala()
    {
        Instantiate(bala, transform.position, bala.transform.rotation);
    }
}
