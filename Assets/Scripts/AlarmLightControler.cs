using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmLightControler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float velocidad = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Light>().intensity = Mathf.PingPong(Time.time * velocidad, 3);
    }


}
