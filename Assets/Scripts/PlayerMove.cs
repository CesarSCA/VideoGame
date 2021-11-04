using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public string nombreJugador = "Juan";
    public int vidasJugador = 3;
    public float vidaJugador = 100.0f;
    public float velocidad = 1.5f;
    public float velocidadRotacion = 10f;
    [SerializeField] private float ejeX = -90f;
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
        Avanzar();
        Rotar();
    }



    private void Avanzar()
    {
        float ejeHorizontal = Input.GetAxisRaw("Horizontal");
        float ejeVertical = Input.GetAxisRaw("Vertical");
        transform.Translate(velocidad * Time.deltaTime * new Vector3(ejeHorizontal, 0, ejeVertical));
    }

    void Rotar()
    {
        ejeX += Input.GetAxis("Mouse X");
        Quaternion angulo = Quaternion.Euler(0, ejeX, 0);
        transform.rotation = angulo;
    }
}
    