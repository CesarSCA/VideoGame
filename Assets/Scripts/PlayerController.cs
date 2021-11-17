using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidadMovimiento = 2.3f;
    public bool hidden;
    [SerializeField] private float ejeX = 0f;
    [SerializeField] private GameObject tablet;
    [SerializeField] private bool tabletActiva = false;
    [SerializeField] private float stamina =  100;
    private Rigidbody rbPlayer;
    float ejeHorizontal;
    float ejeVertical;
    Vector3 moveDirection;
    float rbDrag = 6f;



       // Start is called before the first frame update
    void Start()
    {   
        rbPlayer = GetComponent<Rigidbody>();
        rbPlayer.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {   

        TabletMostrar();
        Correr();
        Rotar();
        Inputs();
        ControlDrag();
    }
    void FixedUpdate()
    {
        Avanzar();
    }

    void Inputs()
    {
        ejeHorizontal = Input.GetAxisRaw("Horizontal");
        ejeVertical = Input.GetAxisRaw("Vertical");
        moveDirection = transform.forward * ejeVertical + transform.right * ejeHorizontal;
    }
    void ControlDrag()
    {
        rbPlayer.drag = rbDrag;
    }
    private void Avanzar()
    {
        rbPlayer.AddForce(moveDirection.normalized * velocidadMovimiento * 10, ForceMode.Acceleration);

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
                velocidadMovimiento = 2f;
                stamina = 0;
                return;
            }
            velocidadMovimiento = 2.6f;
        }
        if(!Input.GetKey(KeyCode.LeftShift))
        {
            stamina += 1.3f;
            if(stamina >= 100)
            {
                velocidadMovimiento = 2.3f;
                stamina = 100;
                return;
            }
            velocidadMovimiento = 2f;
        }
    }

    void TabletMostrar()
    {
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
    
}
    