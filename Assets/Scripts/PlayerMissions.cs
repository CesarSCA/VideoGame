using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMissions : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject missionLight;
    [SerializeField] TextMeshPro tabletsTexto;
    [SerializeField] int numeroMision;
    public bool missionComplete = false;
    float timeToComplete = 10f;


    void Start()
    {
        TextMeshPro texto = tabletsTexto.GetComponent<TextMeshPro>();
        texto.fontSize = 0.06f;
        texto.text = "Tarea_" + numeroMision + " Incompleta";
        texto.color = new Color(1, 0, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshPro texto = tabletsTexto.GetComponent<TextMeshPro>();
        if(missionComplete == false)
        {
            missionLight.GetComponent<Light>().color = new Color(1, 0, 0, 1); 
        } else if(missionComplete == true) 
        {
            missionLight.GetComponent<Light>().color = new Color(0, 1, 0, 1);
            texto.fontSize = 0.06f;
            texto.text = "Tarea_" + numeroMision + " Completada";
            texto.color = new Color(0, 1, 0, 1);
        }
    }

    private void OnTriggerStay(Collider other) {

        if(other.gameObject.CompareTag("Player"))
        {
            TextMeshPro texto = tabletsTexto.GetComponent<TextMeshPro>();
            if(missionComplete == false){
             if(timeToComplete > 0)
              {
              timeToComplete -= Time.deltaTime;
              float tiempo = Mathf.Floor(timeToComplete);
              texto.fontSize = 0.057f;
              texto.text = "Tarea_" + numeroMision + " Completando(" + tiempo + ")";
              } 
             else {
              missionComplete = true;

             }
            }
    
        }
    }
}
