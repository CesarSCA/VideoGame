using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public float daño = 20.0f;
    public Vector3 direccion = new Vector3(0, 0, -1);
    public float velocidad = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Avanzar();
    }

    public void Avanzar()
    {
        transform.position += direccion * velocidad * Time.deltaTime;
    }
}
