using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour
{
    [SerializeField] private GameObject jugador;
    [SerializeField] private float velocidadParaVer = 10;
    public enum TipoEnemigo
    {
        observar,
        asechar
    }

    [SerializeField] private TipoEnemigo tipoEnemigo;
    private string enemyType;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SetEnemyType(tipoEnemigo);
    }

    void SetEnemyType(TipoEnemigo tipoEnemigo)
    {
        switch (tipoEnemigo)
        {
            case TipoEnemigo.observar:
                LookPlayer();
                break;
            
            case TipoEnemigo.asechar:
                MoveTowards();
                break;

            default:
                break;
        }
    }

    private void LookPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation((jugador.transform.position - transform.position));
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, velocidadParaVer * Time.deltaTime);
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
