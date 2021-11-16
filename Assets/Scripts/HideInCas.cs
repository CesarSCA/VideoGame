using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideInCas : MonoBehaviour
{
    // Start is called before the first frame update
    public bool hidden = false;
    [SerializeField] GameObject player;
    [SerializeField] GameObject casilleroInterior;
    [SerializeField] GameObject casilleroSalida;
    float coldDown = 1.5f;

    void Start()
    {
        Debug.Log("Presiona 'Q' para ocultar o mostrar la tablet.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate() {
        if(coldDown > 0)
        {
            coldDown -= Time.deltaTime;
        }
        if(hidden == true)
        {
            player.transform.position = casilleroInterior.transform.position + new Vector3(0, 0.4f, 0);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Presiona 'R' para meterne en el casillero.");
        }
    }

    private void OnTriggerStay(Collider other) {
        if(other.gameObject.CompareTag("Player"))
        {

            if(Input.GetKeyDown(KeyCode.R))
            {   
                if(coldDown > 0)
               {
                return;
               }
                if(hidden == false)
                {
                    player.transform.localScale = new Vector3(0.9f, 1.5f, 0.9f);
                    hidden = true;
                    player.transform.position = casilleroInterior.transform.position + new Vector3(0, 0.4f, 0);
                    coldDown = 1.5f;

                    Debug.Log(hidden);
                    return;
                } else if(hidden == true)
                {
                    player.transform.localScale = new Vector3(1.5f, 2f, 1.5f);
                    hidden = false;
                    player.transform.position = casilleroSalida.transform.position + new Vector3(0, 0.5f, 0);

                    coldDown = 1.5f;
                    Debug.Log(hidden);
                    return;
                }

            }
        }
    }
}
