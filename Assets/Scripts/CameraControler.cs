using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public GameObject[] camaras;
    // Start is called before the first frame update
    void Start()
    {
        camaras[0].SetActive(true);
        camaras[1].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            camaras[0].SetActive(true);
            camaras[1].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            camaras[0].SetActive(false);
            camaras[1].SetActive(true);
        }
    }
}
