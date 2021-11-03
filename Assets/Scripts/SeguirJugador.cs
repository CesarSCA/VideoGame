using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject jugador;
    [SerializeField] private Vector3 distancia = new Vector3(0, 1.5f, -3);

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        transform.position = jugador.transform.position + distancia;
        transform.rotation = jugador.transform.rotation;
    }
}
