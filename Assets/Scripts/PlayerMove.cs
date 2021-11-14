using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float velocidad = 1.5f;
    public float velocidadRotacion = 10f;
    [SerializeField] private float ejeX = 0f;
    // [SerializeField] private bool encogido = false;

    // [SerializeField] private float temporizadorColision = 2.0f;
    // Vector3[] puntos = new []{new Vector3(0, 0.5f, 0), new Vector3(3, 0.5f, 2), new Vector3(-1, 0.5f, 4), new Vector3(2, 0.5f, -3)};
    // Vector3 nuevoPunto;
    // int index;
    // float paredRotacion = 20f;
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

    // private void OnTriggerEnter(Collider other)
    // {
    //     // Debug.Log(other.name);
    //     // Enemigo enemy = other.GetComponent<Enemigo>();
    //     // Debug.Log(enemy);

    //     if (other.gameObject.CompareTag("Portal"))
    //     {
    //         if(encogido == false){
    //             transform.localScale = new Vector3(1f, 1f, 1f);
    //             encogido = true;
    //             Debug.Log("1Anda");
    //             return;
    //         }
    //         if(encogido == true){
    //             transform.localScale = new Vector3(2f, 2f, 2f);
    //             encogido = false;
    //             Debug.Log("2Anda");
    //             return;
    //         }
    //     }

    // }
    // private void OnTriggerStay(Collider other) {


    //     if (other.gameObject.CompareTag("paredDorada"))
    //     {   
    //         temporizadorColision -= Time.deltaTime;
    //         Debug.Log(temporizadorColision);
    //         if (temporizadorColision <= 0)
    //         {
    //             index = Random.Range (0, puntos.Length);
    //             nuevoPunto = puntos[index];
    //             other.transform.position = nuevoPunto;
    //             other.transform.rotation = Quaternion.Euler(0, paredRotacion, 0);
    //             paredRotacion += 20f;

    //             temporizadorColision = 2.0f;
    //         }   

    //     }

    // }
}
    