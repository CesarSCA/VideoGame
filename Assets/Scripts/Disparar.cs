using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public float daño = 20.0f;
    public Vector3 direccion = new Vector3(0, 0, -1);
    public float velocidad = 1.5f;
    public float tempDestruccion = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Avanzar();
        Temporizador();
        if (Input.GetKey(KeyCode.Space))
        {
            if (transform.localScale.magnitude >= 3)
            {
                return;
            }
            transform.localScale = transform.localScale * 2;
        }

    }
    void Temporizador()
    {
        tempDestruccion -= Time.deltaTime;
        if (tempDestruccion <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void Avanzar()
    {
        transform.position += direccion * velocidad * Time.deltaTime;
    }
}
