using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrHaciaJugador : MonoBehaviour
{
    [SerializeField] private GameObject jugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveTowards();
    }
    void MoveTowards()
    {
        Vector3 posicion = jugador.transform.position - transform.position;
        if(posicion.magnitude <= 2){
            return;
        }
        Vector3 direction = (jugador.transform.position - transform.position).normalized;
        transform.position += 1.5f * direction * Time.deltaTime;
    }
}
