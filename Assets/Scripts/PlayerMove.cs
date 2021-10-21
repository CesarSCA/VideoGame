using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public string nombreJugador = "Juan";
    public int vidasJugador = 3;
    public float vidaJugador = 100.0f;
    public float velocidad = 1.5f;
    public Vector3 escalaInicial = new Vector3(2, 3, 2);
    public Vector3 movimientoDir = new Vector3(0, 0, 1);
    //public GameObject espada;

       // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tu nombre es: " + nombreJugador);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Avanzar(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Avanzar(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Avanzar(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Avanzar(Vector3.right);
        }
    }



    public void Avanzar(Vector3 direccion)
    {
        transform.position += direccion * velocidad * Time.deltaTime;
    }
}
    