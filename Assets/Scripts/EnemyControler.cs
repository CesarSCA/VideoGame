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
        SetEnemyType(tipoEnemigo);
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyType == "observador")
        {
            LookPlayer();
        }
        if(enemyType == "asechador")
        {
            MoveTowards();
        }
        if(enemyType == "ambos")
        {
            LookPlayer();
            MoveTowards();
        }
    }

    void SetEnemyType(TipoEnemigo tipoEnemigo)
    {
        switch (tipoEnemigo)
        {
            case TipoEnemigo.observar:
                enemyType = "observador";
                break;
            
            case TipoEnemigo.asechar:
                enemyType = "asechador";
                break;

            default:
                enemyType = "ambos";
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
