using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 2f;
    public float velocidadRotacion = 10f;
    [SerializeField] private float ejeX = 0f;
    [SerializeField] private GameObject tablet;
    [SerializeField] private bool tabletActiva = false;
    [SerializeField] private float stamina =  100;


       // Start is called before the first frame update
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {   
        Correr();
        Avanzar();
        Rotar();
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(tabletActiva == false)
            {
                tablet.SetActive(true);
                tabletActiva = true;
            } else if(tabletActiva == true)
            {
                tablet.SetActive(false);
                tabletActiva = false;
            }
        }
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

    void Correr()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            stamina -= 2f;
            if(stamina <= 0)
            {
                velocidad = 1.3f;
                stamina = 0;
                return;
            }
            velocidad = 5f;
            Debug.Log(Mathf.Ceil(Time.deltaTime));
        }
        if(!Input.GetKey(KeyCode.LeftShift))
        {
            stamina += 1.3f;
            if(stamina >= 100)
            {
                velocidad = 2f;
                stamina = 100;
                return;
            }
            velocidad = 1.3f;
        }
    }
    
}
    